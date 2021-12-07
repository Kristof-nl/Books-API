using Books_API.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_API.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1 Book Title",
                        Describtion = "1 book description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Ganre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {
                        Title = "2nd Book Title",
                        Describtion = "2nd book description",
                        IsRead = false,
                        Ganre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now

                    }
                    );
                    context.SaveChanges();
                }
            }

            
        }
    }
}
