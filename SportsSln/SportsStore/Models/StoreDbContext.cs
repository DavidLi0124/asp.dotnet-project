using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models;

public class StoreDbContext:StoreDbContext {
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
    public DbSet<Product> Products => Set<Product>();
}