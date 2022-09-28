using ItEmperor.Shared;
using Microsoft.EntityFrameworkCore;

namespace ItEmperor.Product.Dal;

public class ProductDbContext : DbContext
{
    public ProductDbContext()
    {
    }
    
    public ProductDbContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var provider = new ConnectionStringProvider(); 
        optionsBuilder.UseSqlServer(provider.Get());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}