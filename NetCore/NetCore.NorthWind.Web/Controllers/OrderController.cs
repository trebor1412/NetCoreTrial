using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NetCore.Core;
using NetCore.NorthWind.Service;


namespace NetCore.NorthWind.Web {
    public class OrderController : Controller {
        public OrderController (IOrderService orderService) {
            this.orderService = orderService;
        }

        private IOrderService orderService { get; }

        public IActionResult Index ([FromQuery] string interval) {
            var searchInterval = TimeIntervalFilterEnum.ThisMonth;
            var filterIntervals = EnumHelper.GetList<TimeIntervalFilterEnum>()                                            
                                            .Select(x => x.ToString());
            if(filterIntervals.Any(x => x == interval)){
                searchInterval = EnumHelper.GetList<TimeIntervalFilterEnum>()
                                           .FirstOrDefault(x => x.ToString() == interval);                
            }
            
            var viewModel = new OrderListViewModel {
                Orders = orderService.GetOrderListByOrderDate (searchInterval.Interval().From, searchInterval.Interval().To).ToList (),
                TimeInterval = searchInterval
            };
            
            return View (viewModel);
        }
    }
}