using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "3",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "4",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Rating = "2",
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "1",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }

            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        Id = 1,
                        Name = "Vũ Văn Quyết",
                        BirthDay = DateTime.Parse("1998-03-18"),
                        Adrres = "Hà Nội",
                        Age = 23
                    },

                    new Student
                    {
                        Id = 2,
                        Name = "Vũ Văn Quyết",
                        BirthDay = DateTime.Parse("1998-03-18"),
                        Adrres = "Hà Nội",
                        Age = 23
                    },

                    new Student
                    {
                       Id = 3,
                        Name = "Vũ Văn Quyết",
                        BirthDay = DateTime.Parse("1998-03-18"),
                        Adrres = "Hà Nội",
                        Age = 23
                    },

                    new Student
                    {
                        Id = 4,
                        Name = "Vũ Văn Quyết",
                        BirthDay = DateTime.Parse("1998-03-18"),
                        Adrres = "Hà Nội",
                        Age = 23
                    },

                    new Student
                    {
                        Id = 5,
                        Name = "Vũ Văn Quyết",
                        BirthDay = DateTime.Parse("1998-03-18"),
                        Adrres = "Hà Nội",
                        Age = 23
                    }
                );
                context.SaveChanges();
            }

            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employee.AddRange(
                    new Employee
                    {
                        EmployeeID = "1",
                        EmployeeName = "Vũ Văn Quyết",
                        PhoneNumber = "0971581891"
                    },

                    new Employee
                    {
                        EmployeeID = "2",
                        EmployeeName = "Vũ Văn Quyết",
                        PhoneNumber = "0971581891"
                    },

                    new Employee
                    {
                        EmployeeID = "3",
                        EmployeeName = "Vũ Văn Quyết",
                        PhoneNumber = "0971581891"
                    },

                    new Employee
                    {
                        EmployeeID = "4",
                        EmployeeName = "Vũ Văn Quyết",
                        PhoneNumber = "0971581891"
                    },

                    new Employee
                    {
                        EmployeeID = "5",
                        EmployeeName = "Vũ Văn Quyết",
                        PhoneNumber = "0971581891"
                    }
                );
                context.SaveChanges();
            }
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Person.Any())
                {
                    return;   // DB has been seeded
                }

                context.Person.AddRange(
                    new Person
                    {
                        PersonID = "1",
                        PersonName = "Vũ Văn Quyết"
                    },

                    new Person
                    {
                        PersonID = "2",
                        PersonName = "Vũ Văn Quyết"
                    },

                    new Person
                    {
                        PersonID = "3",
                        PersonName = "Vũ Văn Quyết"
                    },

                    new Person
                    {
                        PersonID = "4",
                        PersonName = "Vũ Văn Quyết"
                    },

                    new Person
                    {
                        PersonID = "5",
                        PersonName = "Vũ Văn Quyết"
                    }
                );
                context.SaveChanges();
            }

            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        ProductID = "1",
                        ProductName = "Sắt",
                        UnitPrice = "10000đ",
                        Quantity = "100"
                    },

                    new Product
                    {
                        ProductID = "2",
                        ProductName = "Sắt",
                        UnitPrice = "10000đ",
                        Quantity = "100"
                    },

                    new Product
                    {
                        ProductID = "3",
                        ProductName = "Sắt",
                        UnitPrice = "10000đ",
                        Quantity = "100"
                    },

                    new Product
                    {
                        ProductID = "4",
                        ProductName = "Sắt",
                        UnitPrice = "10000đ",
                        Quantity = "100"
                    },

                    new Product
                    {
                        ProductID = "5",
                        ProductName = "Sắt",
                        UnitPrice = "10000đ",
                        Quantity = "100"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}