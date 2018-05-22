using NetCore.Repository;
using System.Linq;

namespace NetCore.NorthWind.Repository
{    
    public interface IOrderRepository: INorthWindRepositoryBase<Orders>
    {
        IQueryable<Orders> GetOrderListByCustomer(string customerID);

        IQueryable<Orders> GetOrderListByShipCountry(string shipCountry);
    }
}