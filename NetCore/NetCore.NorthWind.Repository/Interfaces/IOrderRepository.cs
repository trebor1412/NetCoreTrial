using NetCore.Repository;
using System.Linq;
using System;

namespace NetCore.NorthWind.Repository
{    
    public interface IOrderRepository: INorthWindRepositoryBase<Orders>
    {
        IQueryable<Orders> GetOrderListByCustomer(string customerId);

        IQueryable<Orders> GetOrderListByShipCountry(string shipCountry);

        IQueryable<Orders> GetOrderListByOrderTime(DateTime from, DateTime to);
    }
}