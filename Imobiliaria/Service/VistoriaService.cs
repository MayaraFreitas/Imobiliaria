using Imobiliaria.Data.Repository;
using Imobiliaria.Resources;
using Imobiliaria.Service.VOs;
using Imobiliaria.Service.VOs.Solicitacao;
using System;
using System.Collections.Generic;

namespace Imobiliaria.Service
{
    public interface IVistoriaService
    {
        #region Solicitação
        string InserirSolicitacao(SolicitacaoVO solicitacao);
        IEnumerable<ViewSolicitacaoVO> BuscarViewSolicitacao(SolicitacaoFiltroVO filtro);
        IList<SolicitacaoVO> FindAll(); // somente para teste
        #endregion
    }
    public class VistoriaService : IVistoriaService
    {
        #region Injeção

        private readonly IVistoriaRepository _vistoriaRepo;

        public VistoriaService(IVistoriaRepository vistoriaRepository)
        {
            _vistoriaRepo = vistoriaRepository;
        }

        #endregion

        #region Metodos

        #region Solicitacao

        public string InserirSolicitacao(SolicitacaoVO solicitacao)
        {
            string resultado = solicitacao.Validar();
            if (!string.IsNullOrEmpty(resultado))
            {
                return resultado;
            }

            solicitacao.CriarSolicitacao();
            _vistoriaRepo.InserirSolicitacao(solicitacao);
            return null;
        }

        public IEnumerable<ViewSolicitacaoVO> BuscarViewSolicitacao(SolicitacaoFiltroVO filtro)
        {
            string msg = filtro.Validar();
            if (!string.IsNullOrEmpty(msg))
            {
                //adicionar out para retornar mensagem e adicionar try catch
            }
            return _vistoriaRepo.BuscarViewSolicitacao(filtro);
        }

        public IList<SolicitacaoVO> FindAll()
        {
            return _vistoriaRepo.FindAll();
        }

        #endregion

        #region Vistoria

        public string InserirVistoria(VistoriaVO vistoria)
        {
            try
            {
                vistoria.IniciarVistoria();
                //_vistoriaRepo.InserirVistoria(vistoria);
                return null;
            }
            catch (Exception ex)
            {
                // Logar exception
                return Resource.Vistoria_Criar_ErroGenerico;
            }
            
        }

        #endregion

        #endregion
    }
}
