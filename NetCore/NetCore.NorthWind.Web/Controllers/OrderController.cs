using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NetCore.NorthWind.Service;
using NetCore.Core;

namespace NetCore.NorthWind.Web
{
    public class OrderController : Controller
    {
        public OrderController(IOrderService orderService){
            this.orderService = orderService;
        }

        private IOrderService orderService { get; }

        public IActionResult Index(){ 
            var interval = TimeInterval.Interval(TimeIntervalEnum.Month);
            var viewModel = new OrderListViewModel{
                Orders = orderService.GetOrderListByOrderDate(interval.From, interval.To).ToList()
            };
            return View(viewModel);            
        }
    }
}