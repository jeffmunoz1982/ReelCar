using Ardalis.GuardClauses;
using ReelCar.Architecture.SharedKernel;
using ReelCar.Architecture.SharedKernel.Interfaces;

namespace ReelCar.Architecture.Core.ProjectAggregate;

public class CatalogBrand : EntityBase, IAggregateRoot
{
    public string Brand { get; private set; }
    public CatalogBrand(string brand)
    {
        Brand = brand;
    }
}
