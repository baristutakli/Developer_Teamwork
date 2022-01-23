using GenericRepositoryPattern.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryPattern.Services.Helpers
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<AppDbContext>();
            // update database if there is a new migration
            context.Database.Migrate();

            // add category if there is none
            if (context.Set<Category>().Count() == 0)
            {
                context.Set<Category>().AddRange(
                    new List<Category>()
                    {
                        new Category(){Name="Elektronik",Status=true},
                        new Category(){Name="Kırtasiye",Status=true},
                        new Category(){Name="Ofis",Status=true},
                        new Category(){Name="Oyuncak",Status=true},

                    }
                    );
            }
            // add product if there is none
            if (context.Set<Product>().Count() == 0)
            {
                context.Set<Product>().AddRange(
                new List<Product>()
                {
                    new Product(){Description="Açıklama 1", Name="Ürün 1",CategoryId=1,Status=true},
                    new Product(){Description="Açıklama 2", Name="Ürün 2",CategoryId=2,Status=true},
                    new Product(){Description="Açıklama 3", Name="Ürün 3",CategoryId=3,Status=true},
                    new Product(){Description="Açıklama 4", Name="Ürün 4",CategoryId=4,Status=true},
                }
                );
            }

            context.SaveChanges();

        }
    }
}
