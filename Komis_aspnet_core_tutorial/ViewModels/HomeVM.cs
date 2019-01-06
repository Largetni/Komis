using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Komis_aspnet_core_tutorial.Models;

namespace Komis_aspnet_core_tutorial.ViewModels
{
    public class HomeVM
    {
        public string Tytul { get; set; }
        public List<Samochod> Samochody { get; set; }
    }
}
