using ItEmperor.Shared;
using Microsoft.EntityFrameworkCore;

namespace ItEmperor.Party.Tests;

public class PartyDbContext : DbContext
{
    public PartyDbContext() : base()
    {
        
    }
    
    public PartyDbContext(DbContextOptions options) : base(options)
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