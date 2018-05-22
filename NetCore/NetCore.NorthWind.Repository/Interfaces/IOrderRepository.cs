using NetCore.Repository;
using System.Linq;

namespace NetCore.NorthWind.Repository
{    
    public interface IOrderRepository: INorthWindRepositoryBase<Orders>
    {
        IQueryable<Orders> GetOrderListByCustomer(string customerId);

        IQueryable<Orders> GetOrderListByShipCountry(string shipCountry);
    }
}