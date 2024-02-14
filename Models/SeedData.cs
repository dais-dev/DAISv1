using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DAISv1.Data;
using System;
using System.Linq;

namespace DAISv1.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>()))
        {
            if (!context.Asset.Any())
            context.User.AddRange(
                new User  
                { UserName = "U1", Password = "P1"},
                new User 
                { UserName = "U2", Password = "P2" }
            );    
            context.SaveChanges();   


            // Look for any movies.
            if (context.Asset.Any())
            {
                return;   // DB has been seeded
            }
            context.Asset.AddRange(
                new Asset
                {
                    TagId = 111,
                    Name = "MyPump1",
                    Location = "Benguluru",
                    PlantName = "BWSSB",
                    EquipmentType = "Pump",
                    MaterialType  = "PumpType1",
                    PurchaseDate = DateTime.Parse("2020-2-12"),
                    RenewalDate = DateTime.Parse("2024-2-12"),
                    Price = 0.99M
                },
                new Asset
                {
                    TagId = 222,
                    Name = "MyPump2",
                    Location = "Benguluru",
                    PlantName = "BWSSB",
                    EquipmentType = "Pump",
                    MaterialType  = "PumpType1",
                    PurchaseDate = DateTime.Parse("2019-6-6"),
                    RenewalDate = DateTime.Parse("2024-6-6"),
                    Price = 0.89M
                },

                new Asset
                {
                    TagId = 333,
                    Name = "MyValve2",
                    Location = "Pune",
                    PlantName = "PuneCityplant",
                    EquipmentType = "Valve",
                    MaterialType  = "ValveType2",
                    PurchaseDate = DateTime.Parse("2022-1-1"),
                    RenewalDate = DateTime.Parse("2024-1-1"),
                    Price = 0.08M
                },
                new Asset
                {
                    TagId = 444,
                    Name = "MyPump3",
                    Location = "Pune",
                    PlantName = "PuneCityplant",
                    EquipmentType = "Pump",
                    MaterialType  = "PumpType2",
                    PurchaseDate = DateTime.Parse("2023-2-2"),
                    RenewalDate = DateTime.Parse("2026-2-2"),
                    Price = 1.2M
                },
                new Asset
                {
                    TagId = 555,
                    Name = "MyValve1",
                    Location = "Pune",
                    PlantName = "PuneCityplant",
                    EquipmentType = "Valve",
                    MaterialType  = "ValveType1",
                    PurchaseDate = DateTime.Parse("2021-5-3"),
                    RenewalDate = DateTime.Parse("2025-5-3"),
                    Price = 0.07M
                }                
            );
            context.SaveChanges();

            
            
        }
    }
}