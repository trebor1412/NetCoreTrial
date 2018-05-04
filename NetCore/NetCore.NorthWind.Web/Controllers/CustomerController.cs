using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NetCore.NorthWind.Repository;

namespace NetCore.NorthWind.Web {
    public class CustomerController : Controller {
        private readonly ICustomerRepository _repository;

        public CustomerController (ICustomerRepository repository) {
            _repository = repository;
        }

        public IActionResult Index () {                        
            var customers = _repository.GetAll()
                                       .ToList();
    
            return View (model: customers);
        }
    }
}