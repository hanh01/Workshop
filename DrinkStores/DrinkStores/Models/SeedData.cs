using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStores.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "haha",
                        Description = "A boat for one person",
                        //Img = "aaaaaaaaaaa",
                        Price = 275,
                        Discount = 424,
                        Status = "done"
                    },
                     new Product
                     {
                         Name = "haha1",
                         Description = "A boat for one person",
                         //Img = "aaaaaaaaaaa",
                         Price = 275,
                         Discount = 424,
                         Status = "done"
                     },
                      new Product
                      {
                          Name = "haha2",
                          Description = "A boat for one person",
                          //Img = "aaaaaaaaaaa",
                          Price = 275,
                          Discount = 424,
                          Status = "done"
                      },
                       new Product
                       {
                           Name = "haha3",
                           Description = "A boat for one person",
                           //Img = "aaaaaaaaaaa",
                           Price = 275,
                           Discount = 424,
                           Status = "done"
                       }
                    );
                context.SaveChanges();
            }
        }
    }
}
