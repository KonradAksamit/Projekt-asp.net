using Microsoft.EntityFrameworkCore;
using Dziekanat.Models;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Dziekanat.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext( serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                context.Database.EnsureCreated();

                if(context.users.Any())
                {
                    return; // dane już zostały dodane do bazy danych
                }

                var instructor = new Users()
                {
                    Username = "Michał",
                    Password = "Frontczak",
                };

                context.users.Add(instructor);
                context.SaveChanges();

                /* do uzupełnienia */
            }
        } 
    
    }
}
