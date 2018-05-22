using NetCore.NorthWind.Repository;
using System.Collections.Generic;

namespace NetCore.NorthWind.Service
{
    public interface IOrderService
    {
         IList<OrderListItemViewModel> GetOrderListByCustomer(string customerId);
    }
}