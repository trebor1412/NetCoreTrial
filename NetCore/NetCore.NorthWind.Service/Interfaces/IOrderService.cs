using NetCore.NorthWind.Repository;
using System;
using System.Collections.Generic;

namespace NetCore.NorthWind.Service
{
    public interface IOrderService
    {
         IList<OrderListItemViewModel> GetOrderListByCustomer(string customerId);

         IList<OrderListItemViewModel> GetOrderListByOrderDate(DateTime from, DateTime to);
    }
}