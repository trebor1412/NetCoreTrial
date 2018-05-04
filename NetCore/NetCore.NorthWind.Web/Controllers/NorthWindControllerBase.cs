using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCore.NorthWind.Repository;

namespace NetCore.NorthWind.Web {
    public class NorthWindControllerBase : Controller {
        protected readonly NorthWindContext _context;

        public NorthWindControllerBase(NorthWindContext context)
        {
            _context = context;
        }
    }
}