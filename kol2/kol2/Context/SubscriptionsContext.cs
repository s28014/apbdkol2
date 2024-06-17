using kol2.Models;
using Microsoft.EntityFrameworkCore;

namespace kol2.Context;

public class SubscriptionsContext : DbContext
{
    public SubscriptionsContext()
    {
    }

    public SubscriptionsContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Client> Clients { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Payment> Payments { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=db-mssql;Initial Catalog=s28014;Integrated Security=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SubscriptionsContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}