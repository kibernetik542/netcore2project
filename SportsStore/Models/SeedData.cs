using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void GenerateData(IApplicationBuilder app)
        {
            ApplicationDbContext ctx = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            ctx.Database.Migrate();
            if (!ctx.Products.Any())
            {
                ctx.Products.AddRange(
                    new Product
                    {
                        Name = "God Of War:Remastered Collection",
                        Description = "God of War 1, 2, 3 series for PS4 with remastered edition",
                        Price = 59.99M,
                        Category = "Action"
                    },
                    new Product
                    {
                        Name = "The Last Of Us:2",
                        Description = "Amazing continius series of Franchize",
                        Price = 89.99M,
                        Category = "Adventure"

                    },
                    new Product
                    {
                        Name = "Pes 2019",
                        Description = "Amazing graphical exclusive for football fans",
                        Price = 65,
                        Category = "Sport"
                    },
                    new Product
                    {
                        Name = "Uncharted 4:A thief's end",
                        Description = "Adventure of two brothers. Nate and Sam Drake who is treasure hunters",
                        Price = 45,
                        Category = "Adventure"
                    },
                    new Product
                    {
                        Name = "Fifa 2019",
                        Description = "Amazing graphical exclusive for football fans",
                        Price = 75,
                        Category = "Sport"
                    },
                    new Product
                    {
                        Name = "Battlefield 5",
                        Description = "History of 2nd world war",
                        Price = 85.99M,
                        Category = "Action"
                    },
                    new Product
                    {
                        Name = "Uncharted 4:A thief's end",
                        Description = "Adventure of two brothers. Nate and Sam Drake who is treasure hunters",
                        Price = 45,
                        Category = "Adventure"
                    },
                    new Product
                    {
                        Name = "Fifa 2019",
                        Description = "Amazing graphical exclusive for football fans",
                        Price = 75,
                        Category = "Sport"
                    },
                    new Product
                    {
                        Name = "Battlefield 5",
                        Description = "History of 2nd world war",
                        Price = 85.99M,
                        Category = "Action"
                    },
                    new Product
                    {
                        Name = "Uncharted 4:A thief's end",
                        Description = "Adventure of two brothers. Nate and Sam Drake who is treasure hunters",
                        Price = 45,
                        Category = "Adventure"
                    },
                    new Product
                    {
                        Name = "Fifa 2019",
                        Description = "Amazing graphical exclusive for football fans",
                        Price = 75,
                        Category = "Sport"
                    },
                    new Product
                    {
                        Name = "Battlefield 5",
                        Description = "History of 2nd world war",
                        Price = 85.99M,
                        Category = "Action"
                    });
                ctx.SaveChanges();
            }
        }
    }
}