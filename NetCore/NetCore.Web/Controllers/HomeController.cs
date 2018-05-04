using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using NetCore.Model;

namespace NetCore.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var users = new List<User>()
            {
                new User{ Id = 1, Name = "John" },
                new User{ Id = 2, Name = "Mike" },
                new User{ Id = 3, Name = "Rick" }
            };
            return View(model: users);
        }
    }
}