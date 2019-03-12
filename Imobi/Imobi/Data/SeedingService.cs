using Imobi.Models;
using Imobi.Repository.Entities;
using System;
using System.Linq;

namespace Imobi.Data
{
    public class SeedingService
    {
        private ImobiContext _context;

        public SeedingService(ImobiContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            
            if (_context.Vistoria.Any())
            {
                return; // Banco de dados ja populado
            }

            #region Criando Vistoria

            Vistoria vistoria1 = new Vistoria(1, "vistoria1", new DateTime(2019, 01, 20), 1, 1, "OBS 1", true, true, true);
            Vistoria vistoria2 = new Vistoria(2, "vistoria2", new DateTime(2019, 01, 30), 1, 2, "OBS 2", true, true, true);
            Vistoria vistoria3 = new Vistoria(3, "vistoria3", new DateTime(2019, 02, 12), 1, 3, "OBS 3", true, true, false);
            Vistoria vistoria4 = new Vistoria(4, "vistoria4", new DateTime(2019, 02, 27), 1, 4, "OBS 4", true, false, true);
            Vistoria vistoria5 = new Vistoria(5, "vistoria5", new DateTime(2019, 03, 07), 2, 5, "OBS 5", false, true, true);

            _context.AddRange(vistoria1, vistoria2, vistoria3, vistoria4, vistoria5);

            #endregion

            _context.SaveChanges();
        }
    }
}
