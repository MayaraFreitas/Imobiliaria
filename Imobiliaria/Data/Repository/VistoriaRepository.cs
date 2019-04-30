using AutoMapper;
using Imobiliaria.Data.Entities;
using Imobiliaria.Service.VOs;
using Imobiliaria.Service.VOs.Solicitacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Data.Repository
{
    public interface IVistoriaRepository
    {
        #region Solicitação
        void InserirSolicitacao(SolicitacaoVO solicitacao);
        IEnumerable<ViewSolicitacaoVO> BuscarViewSolicitacao(SolicitacaoFiltroVO filtro);
        SolicitacaoVO BuscarSolicitacaoDetalhe(int codigoSolicitacao);
        SolicitacaoVO ExportarPDF(int codigo);
        #endregion

        #region Vistoria
        string InserirVistoria(Vistoria vistoriaVO);
        #endregion

        // teste
        IList<SolicitacaoVO> FindAll();
    }
    public class VistoriaRepository : IVistoriaRepository
    {
        #region Constantes

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        #endregion

        #region Construtor
        public VistoriaRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

        #region Solicitação
        public void InserirSolicitacao(SolicitacaoVO solicitacaoVO)
        {
            Solicitacao solicitacao = _mapper.Map<Solicitacao>(solicitacaoVO);
            _context.Solicitacao.Add(solicitacao);
            _context.SaveChanges();
        }

        public IEnumerable<ViewSolicitacaoVO> BuscarViewSolicitacao(SolicitacaoFiltroVO filtro)
        {
            IEnumerable<ViewSolicitacao> lstSolicitacao = _context.ViewSolicitacao.Where(s =>
            (string.IsNullOrEmpty(filtro.NomeVistoriador) || s.NomeVistoriador.Contains(filtro.NomeVistoriador)) &&
            (string.IsNullOrEmpty(filtro.NomeProprietario) || s.NomeVistoriador.Contains(filtro.NomeProprietario)) &&
            (!filtro.Codigo.HasValue || s.Id == filtro.Codigo) &&
            (!filtro.Status.HasValue || s.Status == filtro.Status) &&
            (!filtro.DataSolicitacao.HasValue || s.DataVistoria >= filtro.DataSolicitacao.Value.Date) &&
            (!filtro.DataAgendamento.HasValue || s.DataVistoria < filtro.DataAgendamento.Value.Date) &&
            (string.IsNullOrEmpty(filtro.EnderecoRua) || s.Rua == filtro.EnderecoRua) &&
            filtro.IdSolicitador == s.IdSolicitador
            ).ToList();

            return _mapper.Map<IEnumerable<ViewSolicitacaoVO>>(lstSolicitacao);
        }

        public SolicitacaoVO BuscarSolicitacaoDetalhe(int codigoSolicitacao)
        {
            Solicitacao solicitacao = _context.Solicitacao.Find(codigoSolicitacao);
            return _mapper.Map<SolicitacaoVO>(solicitacao);
        }

        public SolicitacaoVO ExportarPDF(int codigo)
        {
            Solicitacao solicitacao = _context.Solicitacao.Where(s => s.Id == codigo).First();
            return _mapper.Map<SolicitacaoVO>(solicitacao);
        }
        #endregion

        #region Vistoria

        public string InserirVistoria(Vistoria vistoriaVO)
        {
            //Vistoria vistoria = _mapper.Map


            return null;
        }

        #endregion

        #region Metodos de Teste
        public IList<SolicitacaoVO> FindAll()
        {
            IList<Solicitacao> lstSolicitacao = _context.Solicitacao.ToList();
            return _mapper.Map<IList<SolicitacaoVO>>(lstSolicitacao);
        }
        #endregion
    }
}
