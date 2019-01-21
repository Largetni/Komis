using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis_aspnet_core_tutorial.Models
{
    public class SamochodRepository : ISamochodRepository
    {
        private readonly AppDbContext _appDbContext;

        public SamochodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Samochod PobierzSamochod(int samochodId)
        {
            return _appDbContext.Samochody.FirstOrDefault(s => s.Id == samochodId);
        }

        public IEnumerable<Samochod> PobierzWszystkieSamochody()
        {
            return _appDbContext.Samochody;
        }

        public void DodajSamochod(Samochod samochod)
        {
            _appDbContext.Samochody.Add(samochod);
            _appDbContext.SaveChanges();
        }

        public void EdytujSamochod(Samochod samochod)
        {
            _appDbContext.Samochody.Update(samochod);
            _appDbContext.SaveChanges();
        }

        public void UsunSamochod(Samochod samochod)
        {
            _appDbContext.Samochody.Remove(samochod);
            _appDbContext.SaveChanges();
        }
    }
}
