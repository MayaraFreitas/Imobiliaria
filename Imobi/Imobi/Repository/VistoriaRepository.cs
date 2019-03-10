using Imobi.Models;
using Imobi.Models.ViewModels.Vistoria;
using Imobi.Repository.Exceptions;
using Imobi.Services.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Imobi.Repository
{
    public interface IVistoriaRepository
    {
        List<Vistoria> FindAll();
        void InserirVistoria(Vistoria vistoria);
        void RemoverVistoria(int id);
        void AtualizarVistoria(Vistoria vistoria);
    }

    public class VistoriaRepository : IVistoriaRepository
    {
        private readonly ImobiContext _contex;

        public VistoriaRepository(ImobiContext contex)
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
