using System;
using System.Collections.Generic;
using System.Linq;
using NetCore.NorthWind.Repository;

namespace NetCore.NorthWind.Service {
    public class OrderService : IOrderService {
        public OrderService (IOrderRepository orderRepository) {
            this.orderRepository = orderRepository;
        }

        private IOrderRepository orderRepository { get; }

        private DateTime Now {
            get{
                return DateTime.Now;
            }
        }

        public IList<OrderListItemViewModel> GetOrderListByCustomer (string customerId) {
            var orders = orderRepository.GetOrderListByCustomer(customerId)
                                        .Select(x => new OrderListItemViewModel {
                                            OrderId = x.OrderId,
                                            CustomerId = x.CustomerId,
                                            CustomerName = x.Customer.CompanyName,
                                            OrderDate = x.OrderDate ?? Now,
                                            RequireDate = x.RequiredDate ?? Now,
                                            ShippedDate = x.ShippedDate,
                                            Shipper = x.ShipViaNavigation.CompanyName
                                        })
                                        .ToList();
            return orders;                                        
        }
    }
}