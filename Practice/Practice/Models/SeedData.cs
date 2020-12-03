using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace Practice.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            EmployeeDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<EmployeeDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        Name = "Nguyen Van A",
                        Gender = "Nam",
                        Salary = 10000
                    },
                     new Employee
                     {
                         Name = "Nguyen Van B",
                         Gender = "Nam",
                         Salary = 5000
                     },
                     new Employee
                      {
                          Name = "Nguyen Van C",
                          Gender = "Nam",
                          Salary = 7000
                     },
                      new Employee
                       {
                           Name = "Nguyen Van D",
                           Gender = "Nam",
                           Salary = 9000
                       },
                      new Employee
                        {
                            Name = "Nguyen Van H",
                            Gender = "Nam",
                            Salary = 1000
                      },
                      new Employee
                      {
                          Name = "Nguyen Van Q",
                          Gender = "Nam",
                          Salary = 1500
                      },
                       new Employee
                       {
                           Name = "Nguyen Van Y",
                           Gender = "Nam",
                           Salary = 20000
                       }
                    );
                context.SaveChanges();
            }
        }
    }
}
