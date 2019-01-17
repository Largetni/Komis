using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Komis_aspnet_core_tutorial.Models;

namespace Komis_aspnet_core_tutorial.Controllers
{
    public class OpinieController : Controller
    {
        private readonly IOpiniaRepository _opiniaRepository;

        public OpinieController(IOpiniaRepository opiniaRepository)
        {
            _opiniaRepository = opiniaRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Opinia opinia)
        {
            if (ModelState.IsValid)
            {
                _opiniaRepository.DodajOpinie(opinia);
                return RedirectToAction("OpiniaWyslana");
            }

            return View(opinia);

        }

        public IActionResult OpiniaWyslana()
        {
            return View();
        }


    }
}