using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq.Expressions;
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

        private static IEnumerable<T> OrderByTreeExpression<T>(this IEnumerable<T> sequance, string propertyName)
        {
            // x=>x.propertyName
            ParameterExpression parameterExpression = Expression.Parameter(typeof(T));
            MemberExpression property = Expression.Property(parameterExpression, propertyName);
            Delegate lambda = Expression.Lambda(property, parameterExpression).Compile();

            var orderBy = typeof(Enumerable)
                 .GetMethods(BindingFlags.Public | BindingFlags.Static)
                 .Where(m => m.GetParameters().Length == 2 && m.Name == "OrderBy")
                 .FirstOrDefault()
                 .MakeGenericMethod(typeof(T), property.Type);

            return (IEnumerable<T>)orderBy.Invoke(null, new object[] { sequance, lambda });
        }

        public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> sequance, string propertyName)
        {
            if (propertyName == null)
                return null;

            if (sequance.Count() < 100)
                return OrderBySimpleReflection(sequance, propertyName);
            else
                return OrderByTreeExpression(sequance, propertyName);
        }

        public static IEnumerable<R> GetViews<T, R>(this IEnumerable<T> sequance) where T : class where R : class
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
