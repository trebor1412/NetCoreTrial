using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace NetCore.NorthWind.Web {
    public class HomeController : Controller {
        public IActionResult Index () {
            var users = new List<User> () {
                new User { Id = 1, Name = "John" },
                new User { Id = 2, Name = "Mike" },
                new User { Id = 3, Name = "Rick" }
            };
            return View (model: users);
        }
    }

    public class User {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}