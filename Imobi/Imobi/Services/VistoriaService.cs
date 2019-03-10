using Imobi.Models.ViewModels.Vistoria;
using Imobi.Repository;
using Imobi.Services.ServiceInterface;
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

        #endregion

        #region Construtor

        public VistoriaService(IVistoriaRepository vistoriaRepository)
        {
            _vistoriaRepo = vistoriaRepository;
        }

        #endregion

        public List<Vistoria> FindAll()
        {
            return _vistoriaRepo.FindAll();
        }

        public void InserirVistoria(Vistoria vistoria)
        {
            _vistoriaRepo.InserirVistoria(vistoria);
        }
    }
}
