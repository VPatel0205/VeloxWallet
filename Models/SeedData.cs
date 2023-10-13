using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using VeloxWallet.Data;
using System.Threading.Tasks;

namespace VeloxWallet.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VeloxWalletContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VeloxWalletContext>>()))
            {
                // Look for any movies.
                if (context.Wallet.Any())
                {
                    return;   // DB has been seeded
                }

                context.Wallet.AddRange(
                    new Wallet
                    {
                        MaterialType = "Leather",
                        Type = "Bifold",
                        Edition = "Classic",
                        Make = "Italy, United States",
                        Price = 560,
                        Rating = "4.9"
                    },

                    new Wallet
                    {
                        MaterialType = "Canvas",
                        Type = "Trifold",
                        Edition = "Minimalist",
                        Make = "India",
                        Price = 400,
                       Rating = "4.7"
                    },

                    new Wallet
                    {
                        MaterialType = "Nylon",
                        Type = "Slim",
                        Edition = "Rugged",
                        Make = "United States",
                        Price = 700,
                        Rating = "3.3"
                    },

                    new Wallet
                    {
                        MaterialType = "Synthetic Leather",
                        Type = "Bifold, Trifold",
                        Edition = "Minimalist",
                        Make = "China",
                        Price = 300,
                        Rating = "3.5"
                    },

                    new Wallet
                    {
                        MaterialType = "Metal",
                        Type = "Money Clip",
                        Edition = "Classic",
                        Make = "China",
                        Price = 450,
                        Rating = "3.0"
                    },

                    new Wallet
                    {
                        MaterialType = "Wood",
                        Type = "Bifold",
                        Edition = "Artisan",
                        Make = "Indonesia",
                        Price = 900,
                        Rating = "4.2"
                    },

                    new Wallet
                    {
                        MaterialType = "Tyvek",
                        Type = "Slim",
                        Edition = "Artistic",
                        Make = "United States",
                        Price = 1100,
                        Rating = "4.4"
                    },

                    new Wallet
                    {
                        MaterialType = "Carbon Fiber",
                        Type = "Slim",
                        Edition = "Tech",
                        Make = "United States",
                        Price = 1300,
                        Rating = "4.5"
                    },

                    new Wallet
                    {
                        MaterialType = "Exotic Animal Skins",
                        Type = "Trifold",
                        Edition = "Luxury",
                        Make = "Italy",
                        Price = 2100,
                        Rating = "5.0"
                    },

                    new Wallet
                    {
                        MaterialType = "Elastic/Stretch Material",
                        Type = "Front Pocket",
                        Edition = "Casual",
                        Make = "United States",
                        Price = 600,
                        Rating = "4.0"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

