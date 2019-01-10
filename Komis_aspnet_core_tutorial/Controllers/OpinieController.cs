using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Komis_aspnet_core_tutorial.Controllers
{
    public class OpinieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}