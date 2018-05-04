using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NetCore.NorthWind.Repository;

namespace NetCore.NorthWind.Web {
    public class CustomerController : NorthWindControllerBase {
        public CustomerController (NorthWindContext context) : base (context) {

        }

        public IActionResult Index () {
            var customers = _context.Customers
                                    .ToList();


            return View (model: customers);
        }
    }
}