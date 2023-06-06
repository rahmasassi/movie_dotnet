using movie.Data.Enums;
using movie.Data.Static;
using movie.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://i.ibb.co/4fCBW4k/cinema.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://i.ibb.co/yqkbpg8/cinema2.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://i.ibb.co/4Z4zXMC/cinema3.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://i.ibb.co/YdX8GMJ/cinema4.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://i.ibb.co/FW0ZsMr/cinema5.jpg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Zoran Cvijanovic",
                            Bio = "This is the Bio of the actor Zoran Cvijanovic",
                            ProfilePictureURL = "https://i.ibb.co/SK54MVc/zoran-cvijanovic.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Vuk Kostic",
                            Bio = "This is the Bio of the actor Vuk Kostic",
                            ProfilePictureURL = "https://i.ibb.co/KX7JV1W/vuk-kostic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Tihomir Stanic",
                            Bio = "This is the Bio of the actor Tihomir Stanic",
                            ProfilePictureURL = "https://i.ibb.co/W2GL4QH/tihomir-stanic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Tanja Boskovic",
                            Bio = "This is the Bio of the actor Tanja Boskovic",
                            ProfilePictureURL = "https://i.ibb.co/Kxznf26/tanja-boskovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Srdjan Todorovic",
                            Bio = "This is the Bio of the actor Srdjan Todorovic",
                            ProfilePictureURL = "https://i.ibb.co/GVz3RdV/srdjan-todorovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Sergej Trifunovic",
                            Bio = "This is the Bio of the actor Sergej Trifunovic",
                            ProfilePictureURL = "https://i.ibb.co/R2zysQD/sergej-trifunovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Nikola Rakocevic",
                            Bio = "This is the Bio of the actor Nikola Rakocevic",
                            ProfilePictureURL = "https://i.ibb.co/s23VJj4/nikola-rakocevic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Nikola Djuricko",
                            Bio = "This is the Bio of the actor Nikola Djuricko",
                            ProfilePictureURL = "https://i.ibb.co/sPtjKDN/nikola-djuricko.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Nenad Jezdic",
                            Bio = "This is the Bio of the actor Nenad Jezdic",
                            ProfilePictureURL = "https://i.ibb.co/3NZJsYZ/nenad-jezdic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Nebojsa Glogovac",
                            Bio = "This is the Bio of the actor Nebojsa Glogovac",
                            ProfilePictureURL = "https://i.ibb.co/58zg4jw/nebojsa-glogovac.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Mima Karadzic",
                            Bio = "This is the Bio of the actor Mima Karadzic",
                            ProfilePictureURL = "https://i.ibb.co/48FNC9g/mima-karadzic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Natasa Tapuskovic",
                            Bio = "This is the Bio of the actor Natasa Tapuskovic",
                            ProfilePictureURL = "https://i.ibb.co/4fz1Md1/natasa-tapuskovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Milos Bikovic",
                            Bio = "This is the Bio of the actor Milos Bikovic",
                            ProfilePictureURL = "https://i.ibb.co/dGWzXBF/milos-bikovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Milena Radulovic",
                            Bio = "This is the Bio of the actor Milena Radulovic",
                            ProfilePictureURL = "https://i.ibb.co/8MyhhB5/milena-radulovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Lazar Ristovski",
                            Bio = "This is the Bio of the actor Lazar Ristovski",
                            ProfilePictureURL = "https://i.ibb.co/g9Zjzbt/lazar-ristovski.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Katarina Radivojevic",
                            Bio = "This is the Bio of the actor Katarina Radivojevic",
                            ProfilePictureURL = "https://i.ibb.co/xYbf8D2/katarina-radivojevic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Gordan Kicic",
                            Bio = "This is the Bio of the actor Gordan Kicic",
                            ProfilePictureURL = "https://i.ibb.co/5s0xmXr/gordan-kicic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Dubravka Mijatovic",
                            Bio = "This is the Bio of the actor Dubravka Mijatovic",
                            ProfilePictureURL = "https://i.ibb.co/GvCnWV8/dubravka-mijatovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Goran Radakovic",
                            Bio = "This is the Bio of the actor Goran Radakovic",
                            ProfilePictureURL = "https://i.ibb.co/hLkvrv7/goran-radakovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Dragan Petrovic Pele",
                            Bio = "This is the Bio of the actor Dragan Petrovic Pele",
                            ProfilePictureURL = "https://i.ibb.co/zZ24Bqt/dragan-petrovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Dragan Micanovic",
                            Bio = "This is the Bio of the actor Dragan Micanovic",
                            ProfilePictureURL = "https://i.ibb.co/yR2qwb8/drahan-micanovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Dragan Jovanovic",
                            Bio = "This is the Bio of the actor Dragan Jovanovic",
                            ProfilePictureURL = "https://i.ibb.co/WxZTGTd/dragan-jovanovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Dragan Bjelogrlic",
                            Bio = "This is the Bio of the actor Dragan Bjelogrlic",
                            ProfilePictureURL = "https://i.ibb.co/yP9BQMT/dragan-bjelogrlic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Brankica Sebastijanovic",
                            Bio = "This is the Bio of the actor Brankica Sebastijanovic",
                            ProfilePictureURL = "https://i.ibb.co/L1DDMt7/brankica-sebastijanovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Branka Katic",
                            Bio = "This is the Bio of the actor Branka Katic",
                            ProfilePictureURL = "https://i.ibb.co/cxK4bJx/branka-katic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Boris Milivojevic",
                            Bio = "This is the Bio of the actor Boris Milivojevic",
                            ProfilePictureURL = "https://i.ibb.co/zPYGM92/boris-milivojevic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Andrija Milosevic",
                            Bio = "This is the Bio of the actor Andrija Milosevic",
                            ProfilePictureURL = "https://i.ibb.co/dW9JyYr/andrija-milosevic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Andjela Jovanovic",
                            Bio = "This is the Bio of the actor Andjela Jovanovic",
                            ProfilePictureURL = "https://i.ibb.co/2vZzvx8/andjela-jovanovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Aleksandra Balmazovic",
                            Bio = "This is the Bio of the actor Aleksandra Balmazovic",
                            ProfilePictureURL = "https://i.ibb.co/J5f216y/aleksandra-balmazovic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Aleksandar Radojcic",
                            Bio = "This is the Bio of the actor Aleksandar Radojcic",
                            ProfilePictureURL = "https://i.ibb.co/F6M5YV8/aleksandar-radojcic.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Aleksandar Bercek",
                            Bio = "This is the Bio of the actor Aleksandar Bercek",
                            ProfilePictureURL = "https://i.ibb.co/J5f216y/aleksandra-balmazovic.jpg"
                        }

                    });
                    context.SaveChanges();
                }
              
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Volim te najvise na svetu",
                            Description = "This is the movie description",
                            Price = 850,
                            ImageURL = "https://i.ibb.co/KDK3srH/volim-te-najvise-na-svetu-poster.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Ustanicka ulica",
                            Description = "This is the movie description",
                            Price = 950,
                            ImageURL = "https://i.ibb.co/85WwTFw/ustanicka-ulica-poster.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "3 Palme za 2 bitange i ribicu",
                            Description = "This is the movie description",
                            Price = 1150,
                            ImageURL = "https://i.ibb.co/pQ3FYzk/tri-palme-za-dve-bitange-i-ribicu-poster.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Sivi kamion crvene boje",
                            Description = "This is the movie description",
                            Price = 1000,
                            ImageURL = "https://i.ibb.co/hXQPrTH/sivi-kamion-crvene-boje-poster.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Sesir profesora Kosete Vujica",
                            Description = "This is the movie description",
                            Price = 850,
                            ImageURL = "https://i.ibb.co/7NfLC5r/sesir-profesora-koste-vujica-serija-poster.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Samac u braku",
                            Description = "This is the movie description",
                            Price = 1250,
                            ImageURL = "https://i.ibb.co/jzcJ83f/samac-u-braku-poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Romance
                        },
                        new Movie()
                        {
                            Name = "Necista krv",
                            Description = "This is the movie description",
                            Price = 1150,
                            ImageURL = "https://i.ibb.co/tmyy7qF/necista-krv-poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 12,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Munje",
                            Description = "This is the movie description",
                            Price = 1250,
                            ImageURL = "https://i.ibb.co/Gxnd8yZ/munje-poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Mrtav 'ladan",
                            Description = "This is the movie description",
                            Price = 950,
                            ImageURL = "https://i.ibb.co/bs3NjkD/mrtav-ladan-poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 6,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Mala nocna muzika",
                            Description = "This is the movie description",
                            Price = 1150,
                            ImageURL = "https://i.ibb.co/H2j7S3R/mala-nocna-muzika-poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 7,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Lajanje na zvezde",
                            Description = "This is the movie description",
                            Price = 850,
                            ImageURL = "https://i.ibb.co/Jv8BTkJ/lajanje-na-zvezde-flyer.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Romance
                        },
                        new Movie()
                        {
                            Name = "Kad porastem bicu kengur",
                            Description = "This is the movie description",
                            Price = 950,
                            ImageURL = "https://i.ibb.co/ftQxn6H/kad-porastem-bicu-kengur-poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Balkanska medja",
                            Description = "This is the movie description",
                            Price = 750,
                            ImageURL = "https://i.ibb.co/94CY35X/flyer.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 8,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Taksi bluz",
                            Description = "This is the movie description",
                            Price = 950,
                            ImageURL = "https://i.ibb.co/dpfytGX/flyer-1.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 9,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Falsifikator",
                            Description = "This is the movie description",
                            Price = 950,
                            ImageURL = "https://i.ibb.co/0Qg009G/falsifikator-poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 10,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Branio sam Mladu Bosnu",
                            Description = "This is the movie description",
                            Price = 750,
                            ImageURL = "https://i.ibb.co/gm9FNN6/branio-sam-mladu-bosnu-poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Boomerang",
                            Description = "This is the movie description",
                            Price = 10000,
                            ImageURL = "https://i.ibb.co/jMbZC1H/boomerang-flyer.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 11,
                            MovieCategory = MovieCategory.Comedy
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 8
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 13
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 10
                        },
                         new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 15
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 1
                        },

                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 9
                        },
                        new Actor_Movie()
                        {
                            ActorId = 6,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 7,
                            MovieId = 16
                        },
                        new Actor_Movie()
                        {
                            ActorId = 8,
                            MovieId = 12
                        },

                        new Actor_Movie()
                        {
                            ActorId = 9,
                            MovieId = 9
                        },
                        new Actor_Movie()
                        {
                            ActorId = 10,
                            MovieId = 17
                        },
                        new Actor_Movie()
                        {
                            ActorId = 11,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 12,
                            MovieId = 11
                        },
                        new Actor_Movie()
                        {
                            ActorId = 13,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 13,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 14,
                            MovieId = 12
                        },
                        new Actor_Movie()
                        {
                            ActorId = 15,
                            MovieId = 17
                        },
                        new Actor_Movie()
                        {
                            ActorId = 16,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 17,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 17,
                            MovieId = 10
                        },
                        new Actor_Movie()
                        {
                            ActorId = 11,
                            MovieId = 12
                        },
                        new Actor_Movie()
                        {
                            ActorId = 18,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 19,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 20,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 20,
                            MovieId = 15
                        },
                        new Actor_Movie()
                        {
                            ActorId = 21,
                            MovieId = 11
                        },
                        new Actor_Movie()
                        {
                            ActorId = 22,
                            MovieId = 17
                        },
                        new Actor_Movie()
                        {
                            ActorId = 23,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 24,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 25,
                            MovieId = 15
                        },
                        new Actor_Movie()
                        {
                            ActorId = 26,
                            MovieId = 8
                        },
                        new Actor_Movie()
                        {
                            ActorId = 26,
                            MovieId = 11
                        },
                        new Actor_Movie()
                        {
                            ActorId = 27,
                            MovieId = 14
                        },
                        new Actor_Movie()
                        {
                            ActorId = 28,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 29,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 30,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 30,
                            MovieId = 13
                        },
                        new Actor_Movie()
                        {
                            ActorId = 31,
                            MovieId = 5
                        },
                    });
                    context.SaveChanges();
                }
            }

        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            if (applicationBuilder.ApplicationServices == null)
            {
                //log an error or throw an exception
                Console.WriteLine("Unsuccessful start of application");
                return;
            }
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    var result = await userManager.CreateAsync(newAdminUser, "etickets@1234?");
                    var passwordHasher = userManager.PasswordHasher;
                    var hashedPassword = passwordHasher.HashPassword(newAdminUser, "etickets@1234?");
                    await userManager.UpdateAsync(newAdminUser);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                    }
                    else if (!result.Succeeded)
                    {
                        var errors = result.Errors;
                        foreach (var error in errors)
                        {
                            Console.WriteLine(error.Description);
                        }
                    }
                    else
                    {
                        // admin already exists, proceed with adding to role
                        await userManager.AddToRoleAsync(adminUser, UserRoles.Admin);
                    }
                   
                    string appUserEmail = "user@etickets.com";

                    var appUser = await userManager.FindByEmailAsync(appUserEmail);
                    if (appUser == null)
                    {
                        var newAppUser = new ApplicationUser()
                        {
                            FullName = "Application User",
                            UserName = "app-user",
                            Email = appUserEmail,
                            EmailConfirmed = true
                        };
                        var createResult = await userManager.CreateAsync(newAppUser, "etickets@1234?");
                        if (createResult.Succeeded)
                        {
                            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                        }
                        else if (!createResult.Succeeded)
                        {
                            var errors = createResult.Errors;
                            foreach (var error in errors)
                            {
                                Console.WriteLine(error.Description);
                            }
                        }
                    }
                    else
                    {
                        // user already exists, proceed with adding to role
                        await userManager.AddToRoleAsync(appUser, UserRoles.User);
                    }
                }
            }
        }
    }
}
