namespace AutoRiaBg.Infrastructure.Persistence
{
    using AutoRiaBg.Domain.Entities;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class DatabaseSeed
    {
        public static async Task SeedSampleDataAsync(ApplicationDbContext context, UserManager<User> userManager)
        {
            await SeedDefaultUserAsync(userManager);
            await SeedBrands(context);
        }
        private static async Task SeedDefaultUserAsync(UserManager<User> userManager)
        {
            var defaultUser = new User { FirstName = "admin", Email = "administrator@localhost" };

            if (userManager.Users.All(u => u.Email != defaultUser.Email))
            {
                await userManager.CreateAsync(defaultUser, "Administrator1!");
            }

        }
        private static async Task SeedBrands(ApplicationDbContext context)
        {
            if (context.Brands.Any())
                return;

            List<Brand> list = new List<Brand>
            {
                    new Brand { Name = "Tesla"               , LogoLink = "https://www.carlogos.org/car-logos/tesla-logo.png"         },
                    new Brand { Name = "BMW", LogoLink = "https://www.carlogos.org/car-logos/bmw-logo.png" },
                    new Brand { Name = "Ferrari", LogoLink = "https://www.carlogos.org/car-logos/ferrari-logo.png" },
                    new Brand { Name = "Ford", LogoLink = "https://www.carlogos.org/car-logos/ford-logo.png" },
                    new Brand { Name = "Porsche", LogoLink = "https://www.carlogos.org/car-logos/porsche-logo.png" },
                    new Brand { Name = "Honda", LogoLink = "https://www.carlogos.org/car-logos/honda-logo.png" },
                    new Brand { Name = "Lamborghini", LogoLink = "https://www.carlogos.org/car-logos/lamborghini-logo.png" },
                    new Brand { Name = "Toyota", LogoLink = "https://www.carlogos.org/car-logos/toyota-logo.png" },
                    new Brand { Name = "Bentley", LogoLink = "https://www.carlogos.org/car-logos/bentley-logo.png" },
                    new Brand { Name = "Maserati", LogoLink = "https://www.carlogos.org/car-logos/maserati-logo.png" },
                    new Brand { Name = "Audi", LogoLink = "https://www.carlogos.org/car-logos/audi-logo.png" },
                    new Brand { Name = "Jeep", LogoLink = "https://www.carlogos.org/car-logos/jeep-logo.png" },
                    new Brand { Name = "Subaru", LogoLink = "https://www.carlogos.org/car-logos/subaru-logo.png" },
                    new Brand { Name = "Hyundai", LogoLink = "https://www.carlogos.org/car-logos/hyundai-logo.png" },
                    new Brand { Name = "Jaguar", LogoLink = "https://www.carlogos.org/car-logos/jaguar-logo.png" },
                    new Brand { Name = "Mazda", LogoLink = "https://www.carlogos.org/car-logos/mazda-logo.png" },
                    new Brand { Name = "Ford Mustang", LogoLink = "https://www.carlogos.org/car-logos/ford-mustang-logo.png" },
                    new Brand { Name = "Nissan", LogoLink = "https://www.carlogos.org/car-logos/nissan-logo.png" },
                    new Brand { Name = "Alfa Romeo", LogoLink = "https://www.carlogos.org/car-logos/alfa-romeo-logo.png" },
                    new Brand { Name = "Bugatti", LogoLink = "https://www.carlogos.org/car-logos/bugatti-logo.png" },
                    new Brand { Name = "Buick", LogoLink = "https://www.carlogos.org/car-logos/buick-logo.png" },
                    new Brand { Name = "Lexus", LogoLink = "https://www.carlogos.org/car-logos/lexus-logo.png" },
                    new Brand { Name = "Rolls-Royce", LogoLink = "https://www.carlogos.org/car-logos/rolls-royce-logo.png" },
                    new Brand { Name = "Acura", LogoLink = "https://www.carlogos.org/car-logos/acura-logo.png" },
                    new Brand { Name = "Chevrolet", LogoLink = "https://www.carlogos.org/car-logos/chevrolet-logo.png" },
                    new Brand { Name = "Kia", LogoLink = "https://www.carlogos.org/car-logos/kia-logo.png" },
                    new Brand { Name = "Mercedes-Benz", LogoLink = "https://www.carlogos.org/car-logos/mercedes-benz-logo.png" },
                    new Brand { Name = "Volkswagen", LogoLink = "https://www.carlogos.org/car-logos/volkswagen-logo.png" },
                    new Brand { Name = "Volvo", LogoLink = "https://www.carlogos.org/car-logos/volvo-logo.png" },
                    new Brand { Name = "McLaren", LogoLink = "https://www.carlogos.org/car-logos/mclaren-logo.png" },
                    new Brand { Name = "Mitsubishi", LogoLink = "https://www.carlogos.org/car-logos/mitsubishi-logo.png" },
                    new Brand { Name = "Infiniti", LogoLink = "https://www.carlogos.org/car-logos/infiniti-logo.png" },
                    new Brand { Name = "Suzuki", LogoLink = "https://www.carlogos.org/car-logos/suzuki-logo.png" },
                    new Brand { Name = "Citroën", LogoLink = "https://www.carlogos.org/car-logos/citroen-logo.png" },
                    new Brand { Name = "Fiat", LogoLink = "https://www.carlogos.org/car-logos/fiat-logo.png" },
                    new Brand { Name = "Mini", LogoLink = "https://www.carlogos.org/car-logos/mini-logo.png"    }
            };

            await context.Brands.AddRangeAsync(list);
            await context.SaveChangesAsync();

        }
    }
}
