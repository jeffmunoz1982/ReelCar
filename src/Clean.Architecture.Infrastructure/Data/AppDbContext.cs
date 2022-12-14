using System.Reflection;
using ReelCar.Architecture.Core.ProjectAggregate;
using ReelCar.Architecture.SharedKernel;
using ReelCar.Architecture.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ReelCar.Architecture.Infrastructure.Data;

public class AppDbContext : DbContext
{
  

  public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
  {
  }


  public DbSet<Basket>? Baskets { get; set; }
  public DbSet<CatalogItem>? CatalogItems { get; set; }
  public DbSet<CatalogBrand>? CatalogBrands { get; set; }
  public DbSet<CatalogType>? CatalogTypes { get; set; }
  public DbSet<BasketItem>? BasketItems { get; set; }



  protected override void OnModelCreating(ModelBuilder builder)
  {
    base.OnModelCreating(builder);
    builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

}
