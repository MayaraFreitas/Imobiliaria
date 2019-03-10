using Imobi.Models;
using Imobi.Models.ViewModels.Vistoria;
using Imobi.Services.Exceptions;
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

        public void InserirVistoria(Vistoria vistoria)
        {
            _contex.Vistoria.Add(vistoria);
            _contex.SaveChanges();
        }

        public void RemoverVistoria(int id)
        {
            var vistoria = _contex.Vistoria.Find(id);
            _contex.Vistoria.Remove(vistoria);
            _contex.SaveChanges();
        }

        public void AtualizarVistoria(Vistoria vistoria)
        {
            if (!_contex.Vistoria.Any(x => x.Id == vistoria.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _contex.Update(vistoria);
                _contex.SaveChanges();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
