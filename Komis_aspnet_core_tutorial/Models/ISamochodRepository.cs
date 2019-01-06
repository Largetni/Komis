using System.Collections.Generic;

namespace Komis_aspnet_core_tutorial.Models
{
    public interface ISamochodRepository
    {
        IEnumerable<Samochod> PobierzWszystkieSamochody();
        Samochod PobierzSamochod(int samochodId);
    }
}
