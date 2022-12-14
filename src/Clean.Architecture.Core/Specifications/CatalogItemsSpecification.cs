using System;
using System.Linq;
using Ardalis.Specification;
using ReelCar.Architecture.Core.ProjectAggregate;

namespace ReelCar.Architecture.Core.Specifications;

public class CatalogItemsSpecification : Specification<CatalogItem>
{
    public CatalogItemsSpecification(params int[] ids)
    {
        Query.Where(c => ids.Contains(c.Id));
    }
}
