using Imobi.Models;
using Imobi.Models.ViewModels.Vistoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobi.Services
{
    public class VistoriaService
    {
        private readonly ImobiContext _contex;

        public VistoriaService(ImobiContext contex)
        {
            _contex = contex;
        }

        public List<Vistoria> FindAll()
        {
            return _contex.Vistoria.ToList();
        }
    }
}
