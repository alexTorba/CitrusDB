using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq.Expressions;
using CitrusDB.Model.Entity;

namespace CitrusDB.Model
{
    public static class ExtensionLinq
    {
        private static IEnumerable<T> OrderBySimpleReflection<T>(this IEnumerable<T> sequance, string propertyName)
        {
            return sequance.
                 OrderBy
                 (e => e
                 .GetType()
                 .GetProperties(BindingFlags.Public | BindingFlags.DeclaredOnly)
                 .Where(p => p.Name == propertyName)
                 );
        }

        private static IEnumerable<T> OrderByTreeExpression<T>(this IEnumerable<T> sequance, string propertyName)
        {
            // x=>x.propertyName
            ParameterExpression parameterExpression = Expression.Parameter(typeof(T));
            MemberExpression property = Expression.Property(parameterExpression, propertyName);
            Delegate lambda = Expression.Lambda(property, parameterExpression).Compile();

            var orderBy = typeof(IEnumerable<T>)
                 .GetMethods(BindingFlags.Public | BindingFlags.Static)
                 .Where(m => m.GetParameters().Length == 2 && m.Name == "OrderBy")
                 .FirstOrDefault()
                 .MakeGenericMethod(typeof(T), property.Type);

            return (IEnumerable<T>)orderBy.Invoke(null, new object[] { sequance, lambda });
        }

        public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> sequance, string propertyName)
        {
            if (sequance.Count() < 100)
                return OrderBySimpleReflection(sequance, propertyName);
            else
                return OrderByTreeExpression(sequance, propertyName);
        }

        public static IEnumerable<R> GetView<T, R>(this IEnumerable<T> sequance) where T : class where R : class
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

    }
}
