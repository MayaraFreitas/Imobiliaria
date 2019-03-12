using AutoMapper;
using Imobi.Models;
using Imobi.Models.ViewModels.Vistoria;
using Imobi.Repository.Entities;
using Imobi.Repository.Exceptions;
using Imobi.Services.Exceptions;
using Imobi.Services.VOs.Vistoria;
using System.Collections.Generic;
using System.Linq;

namespace Imobi.Repository
{
    public interface IVistoriaRepository
    {
        IEnumerable<VistoriaVO> FindAll();
        void InserirVistoria(VistoriaVO vistoria);
        void RemoverVistoria(int id);
        void AtualizarVistoria(VistoriaVO vistoria);
    }

    public class VistoriaRepository : IVistoriaRepository
    {

        private readonly ImobiContext _contex;
        private readonly IMapper _mapper;

        public VistoriaRepository(ImobiContext contex, IMapper mapper)
        {
            _contex = contex;
            _mapper = mapper;
        }

        public IEnumerable<VistoriaVO> FindAll()
        {
            IEnumerable<Vistoria> lstVistoria =  _contex.Vistoria.ToList();

            return _mapper.Map<IEnumerable<VistoriaVO>>(lstVistoria);
        }

        public void InserirVistoria(VistoriaVO vistoriaVO)
        {
            Vistoria vistoria = _mapper.Map<Vistoria>(vistoriaVO);

            _contex.Vistoria.Add(vistoria);
            _contex.SaveChanges();
        }

        public void RemoverVistoria(int id)
        {
            var vistoria = _contex.Vistoria.Find(id);
            _contex.Vistoria.Remove(vistoria);
            _contex.SaveChanges();
        }

        public void AtualizarVistoria(VistoriaVO vistoriaVO)
        {
            if (!_contex.Vistoria.Any(x => x.Id == vistoriaVO.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                Vistoria vistoria = _mapper.Map<Vistoria>(vistoriaVO);
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
