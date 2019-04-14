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
    private static IEnumerable<T> OrderBySimpleReflection<T>(this IEnumerable<T> sequance, string propertyName)
    {
      return sequance.
           OrderBy
           (e =>
           {
             var result = e
                  .GetType()
                  .GetProperties()
                  .FirstOrDefault(p => p.Name == propertyName)
                  ?.GetValue(e, null);

             if (result is Group group)
               return group.Name;
             else return result;
           });
    }

    private static IEnumerable<T> OrderByDescendingSimpleReflection<T>(this IEnumerable<T> sequance, string propertyName)
    {
      return sequance.
           OrderByDescending
           (e =>
           {
             var result = e
                      .GetType()
                      .GetProperties()
                      .FirstOrDefault(p => p.Name == propertyName)
                      ?.GetValue(e, null);

             if (result is Group group)
               return group.Name;
             else return result;
           });
    }

    private static IEnumerable<T> WhereSimpleReflection<T>(this IEnumerable<T> sequance, string searchCriteria, string filter)
    {
      return sequance.
           Where
           (e =>
           {
             var result = e
                      .GetType()
                      .GetProperties()
                      .FirstOrDefault(p => p.Name == searchCriteria)
                      ?.GetValue(e, null);

             if (result is Group group)
               return group.Name.ToUpperInvariant().Contains(filter.ToUpperInvariant());
             else return result.ToString().ToUpperInvariant().Contains(filter.ToUpperInvariant());
           });
    }

    private static IEnumerable<T> OrderByTreeExpression<T>(this IEnumerable<T> sequance, string propertyName)
    {
      // x=>x.propertyName
      var parameterExpression = Expression.Parameter(typeof(T));
      var property = Expression.Property(parameterExpression, propertyName);
      var lambda = Expression.Lambda(property, parameterExpression).Compile();

      var orderBy = typeof(Enumerable)
           .GetMethods(BindingFlags.Public | BindingFlags.Static)
           .Where(m => m.GetParameters().Length == 2 && m.Name == "OrderBy")
           .FirstOrDefault()
           .MakeGenericMethod(typeof(T), property.Type);

      return (IEnumerable<T>)orderBy.Invoke(null, new object[] { sequance, lambda });
    }

    private static IEnumerable<T> OrderByDescendingTreeExpression<T>(this IEnumerable<T> sequance, string propertyName)
    {
      // x=>x.propertyName
      var parameterExpression = Expression.Parameter(typeof(T));
      var property = Expression.Property(parameterExpression, propertyName);
      var lambda = Expression.Lambda(property, parameterExpression).Compile();

      var orderBy = typeof(Enumerable)
           .GetMethods(BindingFlags.Public | BindingFlags.Static)
           .Where(m => m.GetParameters().Length == 2 && m.Name == "OrderByDescending")
           .FirstOrDefault()
           .MakeGenericMethod(typeof(T), property.Type);

      return (IEnumerable<T>)orderBy.Invoke(null, new object[] { sequance, lambda });
    }

    private static IEnumerable<T> WhereTreeExpression<T>(this IEnumerable<T> sequance, string searchCriteria, string filter)
    {
      // new x=>x.propertyName.ToUpperInvariant().Contains(filter.ToUpperInvariant())
      var parameterExpression = Expression.Parameter(typeof(T));
      var propfilter = Expression.Constant(filter);
      var property = Expression.Property(parameterExpression, searchCriteria);

      var methodToString = typeof(object).GetMethod("ToString");
      var methodToUpperInvariant = typeof(string).GetMethod("ToUpperInvariant");
      var methodContains = typeof(string).GetMethod("Contains", new[] { typeof(string) });

      //x.propertyName.ToString().ToUpperInvariant()
      var propertyToString = Expression.Call(property, methodToString);
      var propertyToStringToUpper = Expression.Call(propertyToString, methodToUpperInvariant);

      //filter.ToUpperInvariant()
      var filterToUpper = Expression.Call(propfilter, methodToUpperInvariant);

      // new x=>x.propertyName.ToUpperInvariant().Contains(filter.ToUpperInvariant())
      var body = Expression.Call(propertyToStringToUpper, methodContains, filterToUpper);

      var lambda =
          Expression.Lambda<Func<T, bool>>(body, parameterExpression).Compile();

      return sequance.Where(lambda);
    }

    public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> sequance, string propertyName)
    {
      if (propertyName == null) return null;

      if (sequance.Count() < 100)
        return OrderBySimpleReflection(sequance, propertyName);
      else
        return OrderByTreeExpression(sequance, propertyName);
    }

    public static IEnumerable<T> OrderByDescending<T>(this IEnumerable<T> sequance, string propertyName)
    {
      if (propertyName == null) return null;

      if (sequance.Count() < 100)
        return OrderByDescendingSimpleReflection(sequance, propertyName);
      else
        return OrderByDescendingTreeExpression(sequance, propertyName);
    }

    public static IEnumerable<T> Where<T>(this IEnumerable<T> sequance, string searchCriteria, string filter)
    {
      if (searchCriteria == null) return null;

      if (sequance.Count() < 100)
        return WhereSimpleReflection(sequance, searchCriteria, filter);
      else
        return WhereTreeExpression(sequance, searchCriteria, filter);
    }

    public static IEnumerable<R> GetViews<T, R>(this IEnumerable<T> sequance)
        where T : class, IEntity where R : class
    {
      switch (sequance)
      {
        case IEnumerable<Student> students:
          {
            return (IEnumerable<R>)students
                    .Select(s => new StudentView
                    {
                      Id = s.Id,
                      FirstName = s.FirstName,
                      LastName = s.LastName,
                      MiddleName = s.MiddleName,
                      Group = s.Group
                    });
          }

        case IEnumerable<Group> groups:
          {
            return (IEnumerable<R>)groups
                        .Select(g => new GroupView
                        {
                          Id = g.Id,
                          Photo = g.Photo,
                          Name = g.Name,
                          Students = g.Students.Count()
                        }).ToList();
          }
        default:
          break;
      }
      return null;
    }

    public static async Task<IEnumerable<R>> GetViewsAsync<T, R>(this IEnumerable<T> sequance, CancellationToken token)
        where T : class, IEntity where R : class
    {
      return await Task.Run(() =>
      {
        switch (sequance)
        {
          case IEnumerable<Student> students:
            {
              return (IEnumerable<R>)students
                            .Select(s => new StudentView
                            {
                              Id = s.Id,
                              FirstName = s.FirstName,
                              LastName = s.LastName,
                              MiddleName = s.MiddleName,
                              Group = s.Group
                            });
            }

          case IEnumerable<Group> groups:
            {
              return (IEnumerable<R>)groups
                                .Select(g => new GroupView
                                {
                                  Id = g.Id,
                                  Photo = g.Photo,
                                  Name = g.Name,
                                  Students = g.Students.Count()
                                }).ToList();
            }
          default:
            break;
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
              MiddleName = student.MiddleName,
              Group = student.Group
            };
            return (R)(object)result;
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
            return (R)(object)result;
          }

        default:
          break;
      }
      return null;
    }

    public static R GetViewById<T, R>(this IEnumerable<T> sequance, int id)
        where T : class, IEntity
        where R : class, IEntity
    {
      switch (sequance)
      {
        case IEnumerable<Student> students:
          {
            var student = students
               .Where(s => s.Id == id).FirstOrDefault();
            var result = new StudentView
            {
              Id = student.Id,
              FirstName = student.FirstName,
              LastName = student.LastName,
              MiddleName = student.MiddleName,
              Group = student.Group
            };
            return (R)(object)result;
          }

        case IEnumerable<Group> groups:
          {
            var group = groups
              .Where(s => s.Id == id).FirstOrDefault();
            var result = new GroupView
            {
              Id = group.Id,
              Photo = group.Photo,
              Name = group.Name,
              Students = group.Students.Count()
            };
            return (R)(object)result;
          }

        default:
          break;
      }
      return null;
    }
  }
}
