using AutoMapper;
using Imobi.Controllers.DTOs;
using Imobi.Models.ViewModels.Vistoria;
using Imobi.Repository;
using Imobi.Services.ServiceInterface;
using Imobi.Services.VOs.Vistoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobi.Services
{
    public class VistoriaService : IVistoriaService
    {
        #region Propriedades

        private readonly IVistoriaRepository _vistoriaRepo;
        private readonly IMapper _mapper;

        #endregion

        #region Construtor

        public VistoriaService(IVistoriaRepository vistoriaRepo, IMapper mapper)
        {
            _vistoriaRepo = vistoriaRepo;
            _mapper = mapper;
        }

        #endregion

        public IEnumerable<VistoriaDTO> FindAll()
        {
            return _mapper.Map<IEnumerable<VistoriaDTO>>(_vistoriaRepo.FindAll());
        }

        public void InserirVistoria(VistoriaDTO vistoria)
        {
            _vistoriaRepo.InserirVistoria(_mapper.Map<VistoriaVO>(vistoria));
        }
    }
}
