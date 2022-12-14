using System.Threading.Tasks;
using ReelCar.Architecture.Web.ViewModels;

namespace ReelCar.Architecture.Web.Interfaces;

public interface ICatalogItemViewModelService
{
    Task UpdateCatalogItem(CatalogItemViewModel viewModel);
}
