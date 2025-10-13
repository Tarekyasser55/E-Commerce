using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using E_Commerce.Domain.Contracts;


namespace E_Commerce.Presistence.DbInitializers;

internal class DbInitializer(AplicationDbContext appDbContext) : IDbInitializer
{
    public async Task InitializerAsync()
    {
        //create
        //Update
        try
        {
            if ((await appDbContext.Database.GetPendingMigrationsAsync()).Any())
                await appDbContext.Database.MigrateAsync();

            if (!appDbContext.productBrand.Any())
            {
                var BrandsDate = await File.ReadAllTextAsync(@"..\Infrastructure\E-Commerce.Presistence\Context\DataSeed\brands.json");
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var brands = JsonSerializer.Deserialize<List<productBrand>>(BrandsDate,options);
                if (brands != null && brands.Any())
                {
                    appDbContext.productBrand.AddRange(brands);
                }
                await appDbContext.SaveChangesAsync();
            }

            if (!appDbContext.productType.Any())
            {
                var TypesDate = await File.ReadAllTextAsync(@"..\Infrastructure\E-Commerce.Presistence\Context\DataSeed\brands.json");
                var Types = JsonSerializer.Deserialize<List<productType>>(TypesDate);
                if (Types != null && Types.Any())
                {
                    appDbContext.productType.AddRange(Types);
                }
                await appDbContext.SaveChangesAsync();
            }

            if (!appDbContext.products.Any())
            {
                var productsDate = await File.ReadAllTextAsync(@"..\Infrastructure\E-Commerce.Presistence\Context\DataSeed\products.json");
                var products = JsonSerializer.Deserialize<List<productType>>(productsDate);
                if (products != null && products.Any())
                {
                    appDbContext.productType.AddRange(products);
                }
                await appDbContext.SaveChangesAsync();
            }
        }
        catch(Exception)
        {
            throw;
        }
    }
}
