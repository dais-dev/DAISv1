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
              // this was before ASP Identity
            // if (!context.Asset.Any()) {
              
            // context.User.AddRange(
             //   new User  
             //   { UserName = "U1", Password = "P1"},
            ///    new User 
            ///    { UserName = "U2", Password = "P2" }
           /// );    
           /// context.SaveChanges();   
            ///}

            // Look for any movies.
            if (context.Asset.Any())
            {
 
                return;   // DB has been seeded
            }
            context.Asset.AddRange(
                new Asset
                {
                    TagId = 111,
                    AssetMaterialType ="Pump",
                    EquipmentType = "PumpType1",
                    AssetCode =  1111122,
                    AssetQuantity = 1,
                    AssetRegion = "South",
                    LocationOfOperation = "LocationO1",
                    LocationWithRFID = "LocationR1",
                    Division = "Division1",
                    PurchaseDate = DateTime.Parse("2020-2-12"),
                    YearOfInstallation = DateTime.Parse("2024-2-12"),
                    DesignLifeDate = DateTime.Parse("2020-2-12"),
                    EndOfPeriodLifeDate = DateTime.Parse("2024-2-12"),
                    ManufacturerName = "Manufacturer1",
                    SupplierName = "Supplier1",
                    ModelSerialNumber =12345
                },
                new Asset
                {
                   TagId = 222,
                    AssetMaterialType ="Pump",
                    EquipmentType = "PumpType2",
                    AssetCode =  1111133,
                    AssetQuantity = 1,
                    AssetRegion = "South",
                    LocationOfOperation = "LocationO1",
                    LocationWithRFID = "LocationR1",
                    Division = "Division1",
                    PurchaseDate = DateTime.Parse("2021-2-12"),
                    YearOfInstallation = DateTime.Parse("2024-2-12"),
                    DesignLifeDate = DateTime.Parse("2021-2-12"),
                    EndOfPeriodLifeDate = DateTime.Parse("2024-2-12"),
                    ManufacturerName = "Manufacturer1",
                    SupplierName = "Supplier2",
                    ModelSerialNumber =123456
                },

                new Asset
                {
                    TagId = 333,
                    AssetMaterialType ="Motor",
                    EquipmentType = "Manual",
                    AssetCode =  1111144,
                    AssetQuantity = 1,
                    AssetRegion = "South",
                    LocationOfOperation = "LocationO2",
                    LocationWithRFID = "LocationR3",
                    Division = "Division3",
                    PurchaseDate = DateTime.Parse("2020-2-12"),
                    YearOfInstallation = DateTime.Parse("2024-2-12"),
                    DesignLifeDate = DateTime.Parse("2020-2-12"),
                    EndOfPeriodLifeDate = DateTime.Parse("2024-2-12"),
                    ManufacturerName = "Manufacturer1",
                    SupplierName = "Supplier1",
                    ModelSerialNumber =1234567
                },
                new Asset
                {
                 TagId = 444,
                    AssetMaterialType ="Motor",
                    EquipmentType = "Auto",
                    AssetCode =  1111155,
                    AssetQuantity = 1,
                    AssetRegion = "West",
                    LocationOfOperation = "LocationO1",
                    LocationWithRFID = "LocationR1",
                    Division = "Division1",
                    PurchaseDate = DateTime.Parse("2022-2-12"),
                    YearOfInstallation = DateTime.Parse("2025-2-12"),
                    DesignLifeDate = DateTime.Parse("2022-2-12"),
                    EndOfPeriodLifeDate = DateTime.Parse("2025-2-12"),
                    ManufacturerName = "Manufacturer4",
                    SupplierName = "Supplier4",
                    ModelSerialNumber =12345678   
                }
               
            );
            context.SaveChanges();

            
            
        }
    }
}