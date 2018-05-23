using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NetCore.NorthWind.Service;

namespace NetCore.NorthWind.Web
{
    public class OrderController : Controller
    {
        public OrderController(IOrderService orderService){
            this.orderService = orderService;
        }

        private IOrderService orderService { get; }

        public IActionResult Index(){            
            var viewModel = new OrderListViewModel{
                Orders = orderService.GetOrderListByCustomer("GREAL").ToList()
            };
            return View(viewModel);            
        }
    }
}