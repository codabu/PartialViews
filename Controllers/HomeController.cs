using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewAndTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Microsoft()
        {
            return Redirect("https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-5.0");
        }

    }
}
