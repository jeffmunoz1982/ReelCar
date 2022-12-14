using System.ComponentModel.DataAnnotations;

namespace ReelCar.Architecture.Web.Pages.Basket;

public class BasketItemViewModel
{
    public int Id { get; set; }
    public int CatalogItemId { get; set; }
    public string? ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal OldUnitPrice { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor de 0")]
    public int Quantity { get; set; }
  
    public string? PictureUrl { get; set; }
}
