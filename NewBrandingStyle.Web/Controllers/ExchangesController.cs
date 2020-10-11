using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewBrandingStyle.Web.Controllers
{
    public class ExchangesController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
    }
}