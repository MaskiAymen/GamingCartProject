using Microsoft.EntityFrameworkCore;
using GamingCart.Models;

namespace GamingCart.Infrastructure
{
        public class SeedData
        {
                public static void SeedDatabase(DataContext context)
                {
                        context.Database.Migrate();

                        if (!context.Products.Any())
                        {
                                Category action= new Category { Name = "Action", Slug = "action" };
                                Category voiture = new Category { Name = "Voiture", Slug = "voiture" };
                               Category  foot = new Category { Name = "Foot", Slug = "foot" };

                context.Products.AddRange(
                                        new Product
                                        {
                                                Name = "Avengers",
                                                Slug = "action",
                                                Description = "jeux video  ps4 - Just For games",
                                                Price = 999M,
                                                Category = action,
                                                Image = "jeux1.jpg"
                                        },
                                         new Product
                                         {
                                             Name = "Watch_Dogs",
                                             Slug = "action",
                                             Description = "jeux video  ps4 - Just For games",
                                             Price = 999M,
                                             Category = action,
                                             Image = "jeux2.jpg"
                                         },
                                          new Product
                                          {
                                              Name = "THE Callisto Protocol",
                                              Slug = "action",
                                              Description = "jeux video  ps4 - Just For games",
                                              Price = 999M,
                                              Category = action,
                                              Image = "jeux4.jpg"
                                          },
                                           new Product
                                           {
                                               Name = "Project Cars",
                                               Slug = "voiture",
                                               Description = "jeux video  ps4 - Just For games",
                                               Price = 999M,
                                               Category = voiture,
                                               Image = "jeux5.jpg"
                                           },
                                         new Product
                                         {
                                             Name = "Need For Speed",
                                             Slug = "voiture",
                                             Description = "jeux video  ps4 - Just For games",
                                             Price = 999M,
                                             Category = voiture,
                                             Image = "jeux6.jpg"
                                         },
                                          new Product
                                          {
                                              Name = "Need For Speed Payback",
                                              Slug = "voiture",
                                              Description = "jeux video  ps4 - Just For games",
                                              Price = 999M,
                                              Category = voiture,
                                              Image = "jeux7.jpg"
                                          },
                                           new Product
                                           {
                                               Name = "PES 2015",
                                               Slug = "foot",
                                               Description = "jeux video  ps4 - Just For games",
                                               Price = 999M,
                                               Category = foot,
                                               Image = "jeux8.jpg"
                                           },
                                         new Product
                                         {
                                             Name = "FiFa 2020",
                                             Slug = "foot",
                                             Description = "jeux video  ps4 - Just For games",
                                             Price = 999M,
                                             Category = foot,
                                             Image = "jeux9.jpg"
                                         },
                                          new Product
                                          {
                                              Name = "PES 2017",
                                              Slug = "foot",
                                              Description = "jeux video  ps4 - Just For games",
                                              Price = 999M,
                                              Category = foot,
                                              Image = "jeux10.jpg"
                                          }
                                      
                                );

                                context.SaveChanges();
                        }
                }
        }
}