using ReelCar.Architecture.Core.ProjectAggregate;
using ReelCar.Architecture.Web.Pages.Basket;

namespace ReelCar.Architecture.Web.Interfaces;

public interface IBasketViewModelService
{
    Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
    Task<int> CountTotalBasketItems(string username);
    Task<BasketViewModel> Map(Basket basket);
}
