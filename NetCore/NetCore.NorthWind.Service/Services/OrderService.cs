using System;
using System.Collections.Generic;
using System.Linq;
using NetCore.NorthWind.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace NetCore.NorthWind.Service {
    
    public class OrderService : IOrderService {
        public OrderService (IOrderRepository orderRepository, IMapper mapper) {
            this.orderRepository = orderRepository;
            this.mapper = mapper;
        }

        private IOrderRepository orderRepository { get; }

        private IMapper mapper { get; }

        private DateTime Now {
            get{
                return DateTime.Now;
            }
        }

        public IList<OrderListItemViewModel> GetOrderListByCustomer (string customerId) {
            var orders = orderRepository.GetOrderListByCustomer(customerId)
                                        .Include(x => x.Customer)
                                        .Include(x => x.ShipViaNavigation)
                                        .Select(x => mapper.Map<OrderListItemViewModel>(x))
                                        .ToList();
            return orders;                                        
        }

        public IList<OrderListItemViewModel> GetOrderListByOrderDate(DateTime from, DateTime to){
            var orders = orderRepository.GetOrderListByOrderTime(from, to)
                                        .Include(x => x.Customer)
                                        .Include(x => x.ShipViaNavigation)
                                        .Select(x => mapper.Map<OrderListItemViewModel>(x))
                                        .OrderBy(x => x.OrderDate)
                                        .ToList();
            return orders;
        }
    }
}