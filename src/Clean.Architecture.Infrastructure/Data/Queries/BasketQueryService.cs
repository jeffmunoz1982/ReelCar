using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReelCar.Architecture.Core.Interfaces;
using ReelCar.Architecture.Infrastructure.Data;

namespace ReelCar.Architecture.Infrastructure.Data.Queries;

public class BasketQueryService : IBasketQueryService
{
    private readonly AppDbContext _dbContext;

    public BasketQueryService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// This method performs the sum on the database rather than in memory
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    public async Task<int> CountTotalBasketItems(string username)
    {
    var totalItems = 0;
    if (_dbContext.Baskets != null)
    {
       totalItems = await _dbContext.Baskets
          .Where(basket => basket.BuyerId == username)
          .SelectMany(item => item.Items)
          .SumAsync(sum => sum.Quantity);
    }

        return totalItems;
    }
}
