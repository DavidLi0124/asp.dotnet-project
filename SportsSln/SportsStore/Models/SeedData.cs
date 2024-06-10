using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models;

public static class SeedData {
    public static void EnsurePopulated(IApplicationBuilder app) {
        StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
        if(context.Database.GetPendingMigrations().Any()) {
            context.Database.Migrate();
        }

        if(!context.Products.Any()) {
            context.Products.AddRange(
                new Product
                {
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Category = "WaterSports",
                    Price = 275M
                },
                new Product
                {
                    Name = "Lifejacket",
                    Description = "Protective and fashionable",
                    Category = "Soccer",
                    Price = 48.95M
                },
                new Product
                {
                    Name = "Soccer Ball",
                    Description = "FIFA-approved size and weight",
                    Category = "Soccer",
                    Price = 19.50M
                }
            );
            context.SaveChanges();
        }
    }
}