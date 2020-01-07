using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq.Expressions;
using System.Threading;
using CitrusDB.Model.Entity;

namespace CitrusDB.Model.Extensions
{
  public static class ExtensionLinq
  {
    private static IEnumerable<T> OrderBySimpleReflection<T>(this IEnumerable<T> sequence, string propertyName)
    {
      return sequence.OrderBy(e =>
      {
        var result = e
          .GetType()
          .GetProperties()
          .FirstOrDefault(p => p.Name == propertyName)
          ?.GetValue(e, null);
        return result is Group group ? group.Name : result;
      });
    }

    private static IEnumerable<T> OrderByDescendingSimpleReflection<T>(this IEnumerable<T> sequence,
      string propertyName)
    {
      return sequence.OrderByDescending(e =>
      {
        var result = e
          .GetType()
          .GetProperties()
          .FirstOrDefault(p => p.Name == propertyName)
          ?.GetValue(e, null);

        return result is Group group ? group.Name : result;
      });
    }

    private static IEnumerable<T> WhereSimpleReflection<T>(this IEnumerable<T> sequence, string searchCriteria,
      string filter)
    {
      return sequence.Where(e =>
      {
        var result = e
          .GetType()
          .GetProperties()
          .FirstOrDefault(p => p.Name == searchCriteria)
          ?.GetValue(e, null);

        return result is Group group
          ? group.Name.ToUpperInvariant().Contains(filter.ToUpperInvariant())
          : result.ToString().ToUpperInvariant().Contains(filter.ToUpperInvariant());
      });
    }

    private static IEnumerable<T> OrderByTreeExpression<T>(this IEnumerable<T> sequence, string propertyName)
    {
      // x=>x.propertyName
      var parameterExpression = Expression.Parameter(typeof(T));
      var property = Expression.Property(parameterExpression, propertyName);
      var lambda = Expression.Lambda(property, parameterExpression).Compile();

      var orderBy = typeof(Enumerable)
        .GetMethods(BindingFlags.Public | BindingFlags.Static)
        .FirstOrDefault(m => m.GetParameters().Length == 2 && m.Name == "OrderBy")
        ?.MakeGenericMethod(typeof(T), property.Type);

      return (IEnumerable<T>) orderBy.Invoke(null, new object[] {sequence, lambda});
    }

    private static IEnumerable<T> OrderByDescendingTreeExpression<T>(this IEnumerable<T> sequence, string propertyName)
    {
      // x=>x.propertyName
      var parameterExpression = Expression.Parameter(typeof(T));
      var property = Expression.Property(parameterExpression, propertyName);
      var lambda = Expression.Lambda(property, parameterExpression).Compile();

      var orderBy = typeof(Enumerable)
        .GetMethods(BindingFlags.Public | BindingFlags.Static)
        .FirstOrDefault(m => m.GetParameters().Length == 2 && m.Name == "OrderByDescending")
        ?.MakeGenericMethod(typeof(T), property.Type);

      return (IEnumerable<T>) orderBy.Invoke(null, new object[] {sequence, lambda});
    }

    private static IEnumerable<T> WhereTreeExpression<T>(this IEnumerable<T> sequence, string searchCriteria,
      string filter)
    {
      // new x=>x.propertyName.ToUpperInvariant().Contains(filter.ToUpperInvariant())
      var parameterExpression = Expression.Parameter(typeof(T));
      var propFilter = Expression.Constant(filter);
      var property = Expression.Property(parameterExpression, searchCriteria);

      var methodToString = typeof(object).GetMethod("ToString");
      var methodToUpperInvariant = typeof(string).GetMethod("ToUpperInvariant");
      var methodContains = typeof(string).GetMethod("Contains", new[] {typeof(string)});

      //x.propertyName.ToString().ToUpperInvariant()
      var propertyToString = Expression.Call(property, methodToString);
      var propertyToStringToUpper = Expression.Call(propertyToString, methodToUpperInvariant);

      //filter.ToUpperInvariant()
      var filterToUpper = Expression.Call(propFilter, methodToUpperInvariant);

      // new x=>x.propertyName.ToUpperInvariant().Contains(filter.ToUpperInvariant())
      var body = Expression.Call(propertyToStringToUpper, methodContains, filterToUpper);

      var lambda = Expression.Lambda<Func<T, bool>>(body, parameterExpression).Compile();

      return sequence.Where(lambda);
    }

    public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> sequence, string propertyName)
    {
      if (propertyName == null) return null;

      return sequence.Count() < 100
        ? OrderBySimpleReflection(sequence, propertyName)
        : OrderByTreeExpression(sequence, propertyName);
    }

    public static IEnumerable<T> OrderByDescending<T>(this IEnumerable<T> sequence, string propertyName)
    {
      if (propertyName == null) return null;

      return sequence.Count() < 100
        ? OrderByDescendingSimpleReflection(sequence, propertyName)
        : OrderByDescendingTreeExpression(sequence, propertyName);
    }

    public static IEnumerable<T> Where<T>(this IEnumerable<T> sequence, string searchCriteria, string filter)
    {
      if (searchCriteria == null) return null;

      return sequence.Count() < 100
        ? WhereSimpleReflection(sequence, searchCriteria, filter)
        : WhereTreeExpression(sequence, searchCriteria, filter);
    }

    public static IEnumerable<R> GetViews<T, R>(this IEnumerable<T> sequence)
      where T : class, IEntity 
      where R : class
    {
      switch (sequence)
      {
        case IEnumerable<Student> students:
        {
          return (IEnumerable<R>) students
            .Select(s => new StudentView
            {
              Id = s.Id,
              FirstName = s.FirstName,
              LastName = s.LastName,
              MiddleName = s.MiddleName
            });
        }

        case IEnumerable<Group> groups:
        {
          return (IEnumerable<R>) groups
            .Select(g => new GroupView
            {
              Id = g.Id,
              Photo = g.Photo,
              Name = g.Name,
              Students = g.Students.Count()
            }).ToList();
        }
      }

      return null;
    }

    public static async Task<IEnumerable<R>> GetViewsAsync<T, R>(this IEnumerable<T> sequence, CancellationToken token)
      where T : class, IEntity where R : class
    {
      return await Task.Run(() =>
      {
        switch (sequence)
        {
          case IEnumerable<Student> students:
          {
            return (IEnumerable<R>) students
              .Select(s => new StudentView
              {
                Id = s.Id,
                FirstName = s.FirstName,
                LastName = s.LastName,
                MiddleName = s.MiddleName
              });
          }

          case IEnumerable<Group> groups:
          {
            return (IEnumerable<R>) groups
              .Select(g => new GroupView
              {
                Id = g.Id,
                Photo = g.Photo,
                Name = g.Name,
                Students = g.Students.Count()
              }).ToList();
          }
        }

        return null;
      }, token);
    }

    public static R GetView<T, R>(this T entity)
      where T : class, IEntity
      where R : class, IEntity
    {
      switch (entity)
      {
        case Student student:
        {
          var result = new StudentView
          {
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            MiddleName = student.MiddleName
          };
          return (R) (object) result;
        }

        case Group group:
        {
          var result = new GroupView
          {
            Id = group.Id,
            Photo = group.Photo,
            Name = group.Name,
            Students = group.Students.Count()
          };
          return (R) (object) result;
        }
      }

      return null;
    }

    public static R GetViewById<T, R>(this IEnumerable<T> sequence, int id)
      where T : class, IEntity
      where R : class, IEntity
    {
      switch (sequence)
      {
        case IEnumerable<Student> students:
        {
          var student = students.FirstOrDefault(s => s.Id == id);
          var result = new StudentView
          {
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            MiddleName = student.MiddleName
          };
          return (R) (object) result;
        }

        case IEnumerable<Group> groups:
        {
          var group = groups.FirstOrDefault(s => s.Id == id);
          var result = new GroupView
          {
            Id = group.Id,
            Photo = group.Photo,
            Name = group.Name,
            Students = group.Students.Count()
          };
          return (R) (object) result;
        }
      }

      return null;
    }
  }
}