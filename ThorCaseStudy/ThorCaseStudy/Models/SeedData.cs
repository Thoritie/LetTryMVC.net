using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ThorCaseStudy.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
			using (var context = new ThorCaseStudyContext(
				serviceProvider.GetRequiredService<DbContextOptions<ThorCaseStudyContext>>()))
            {
                // Look for any movies.
                if (context.Thor.Any())
                {
                    return;   // DB has been seeded
                }

                context.Thor.AddRange(
                     new Thor
                     {
                         Title = "When Harry Met Sally",
                       
                     },

                     new Thor
                     {
                         Title = "Ghostbusters ",
                        
                     },
                    
                     new Thor
                     {
                         Title = "Ghostbusters 2",
                       
                     },

                   new Thor
                   {
                       Title = "Rio Bravo",
                    
                   }
                );
                context.SaveChanges();
            }
        }
    }
}