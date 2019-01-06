using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Komis_aspnet_core_tutorial.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Komis_aspnet_core_tutorial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISamochodRepository _samochodRepository;

        public HomeController(ISamochodRepository samochodRepository)
        {
            _samochodRepository = samochodRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Tytul = "Przegląd Samochodwów";

            var samochody = _samochodRepository.PobierzWszystkieSamochody().OrderBy(s => s.Marka);

            return View(samochody);
        }
    }
}
