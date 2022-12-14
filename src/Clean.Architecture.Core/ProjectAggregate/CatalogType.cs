
using ReelCar.Architecture.SharedKernel;
using ReelCar.Architecture.SharedKernel.Interfaces;

namespace ReelCar.Architecture.Core.ProjectAggregate;

public class CatalogType :EntityBase, IAggregateRoot
{
    public string Type { get; private set; }
    public CatalogType(string type)
    {
        Type = type;
    }
}
