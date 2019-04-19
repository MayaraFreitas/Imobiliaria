using Imobiliaria.Data.Repository;
using Imobiliaria.Service.VOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Service
{
    public interface IVistoriaService
    {
        void InserirSolicitacao(SolicitacaoVO solicitacaoVO);
        IList<SolicitacaoVO> FindAll();
    }
    public class VistoriaService : IVistoriaService
    {
        #region Injeção

        private readonly IVistoriaRepository _vistoriaRepo;

        public VistoriaService(IVistoriaRepository vistoriaRepository)
        {
            _vistoriaRepo = vistoriaRepository;
        }

        # endregion

        #region Metodos

        public void InserirSolicitacao(SolicitacaoVO solicitacaoVO)
        {
            _vistoriaRepo.InserirSolicitacao(solicitacaoVO);
        }

        public IList<SolicitacaoVO> FindAll()
        {
            return _vistoriaRepo.FindAll();
        }

        #endregion
    }
}
