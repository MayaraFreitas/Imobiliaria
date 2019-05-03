using Imobiliaria.Data.Repository;
using Imobiliaria.Resources;
using Imobiliaria.Service.VOs;
using Imobiliaria.Service.VOs.Solicitacao;
using Imobiliaria.Service.VOs.Vistoria;
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
        SolicitacaoVO ExportarPDF(int codigo);//teste relatorio
        #endregion

        #region Vistoria

        string InserirVistoria(VistoriaVO vistoriaVO);
        string InserirComodo(ComodoVO comodoVO);
        IEnumerable<ViewComodoVO> BuscarViewComodo(int idVistoria);
        string InserirNota(NotaVO notaVO);
        IEnumerable<ViewNotaVO> BuscarViewNota(int idComodo);
        string InserirMedicao(MedicaoVO medicaoVO);

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

        public SolicitacaoVO ExportarPDF(int codigo)
        {
            return _vistoriaRepo.ExportarPDF(codigo);
        }
        #endregion

        #region Vistoria

        public string InserirVistoria(VistoriaVO vistoriaVO)
        {
            try
            {
                vistoriaVO.IniciarVistoria();
                _vistoriaRepo.InserirVistoria(vistoriaVO);
                return null;
            }
            catch (Exception ex)
            {
                // Logar exception
                return Resource.Vistoria_Criar_ErroGenerico;
            }
        }

        #region Comodos
        public string InserirComodo(ComodoVO comodoVO)
        {
            try
            {
                string msg = comodoVO.Validar();
                if (!string.IsNullOrEmpty(msg))
                {
                    return msg;
                }
                _vistoriaRepo.InserirComodo(comodoVO);

                return null;
            }
            catch (Exception ex)
            {
                return Resource.Nota_Criar_ErroGenerico;
            }
            
        }
        public IEnumerable<ViewComodoVO> BuscarViewComodo(int idVistoria)
        {
            return _vistoriaRepo.BuscarViewComodo(idVistoria);
        }
        #endregion

        #region Notas

        public string InserirNota(NotaVO notaVO)
        {
            try
            {
                string msg = notaVO.Validar();
                if (!string.IsNullOrEmpty(msg))
                {
                    return msg;
                }
                _vistoriaRepo.InserirNota(notaVO);

                return null;
            }
            catch (Exception ex)
            {
                return Resource.Nota_Criar_ErroGenerico;
            }
        }

        public IEnumerable<ViewNotaVO> BuscarViewNota(int idComodo)
        {
            return _vistoriaRepo.BuscarViewNota(idComodo);
        }

        #endregion

        #region Medicao

        public string InserirMedicao(MedicaoVO medicaoVO)
        {
            try
            {
                string msg = medicaoVO.Validar();
                if (!string.IsNullOrEmpty(msg))
                {
                    return msg;
                }
                _vistoriaRepo.InserirMedicao(medicaoVO);

                return null;
            }
            catch (Exception ex)
            {
                return Resource.Medicao_Criar_ErroGenerico;
            }
        }

        #endregion

        #endregion

        #endregion
    }
}
