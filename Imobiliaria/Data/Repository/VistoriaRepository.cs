using AutoMapper;
using Imobiliaria.Data.Entities;
using Imobiliaria.Helpers;
using Imobiliaria.Service.VOs;
using Imobiliaria.Service.VOs.Solicitacao;
using Imobiliaria.Service.VOs.Vistoria;
using System.Collections.Generic;
using System.Linq;

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
        void InserirVistoria(VistoriaVO vistoriaVO);
        void InserirComodo(ComodoVO comodoVO);
        IEnumerable<ViewComodoVO> BuscarViewComodo(int idVistoria);
        void InserirNota(NotaVO notaVO);
        IEnumerable<ViewNotaVO> BuscarViewNota(int idComodo);
        void InserirMedicao(MedicaoVO medicaoVO);
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

        #region Metodos

        #region Solicitação
        public void InserirSolicitacao(SolicitacaoVO solicitacaoVO)
        {
            Solicitacao solicitacao = _mapper.Map<Solicitacao>(solicitacaoVO);
            _context.Solicitacao.Add(solicitacao);
            _context.SaveChanges();
        }

        public IEnumerable<ViewSolicitacaoVO> BuscarViewSolicitacao(SolicitacaoFiltroVO filtro)
        {
            if (filtro.TipoUsuario == Constants.Cargo.Administrativo)
            {
                IEnumerable<ViewSolicitacao> lstSolicitacao = _context.ViewSolicitacao.Where(s =>
                (string.IsNullOrEmpty(filtro.NomeVistoriador) || s.NomeVistoriador.Contains(filtro.NomeVistoriador)) &&
                (string.IsNullOrEmpty(filtro.NomeProprietario) || s.NomeVistoriador.Contains(filtro.NomeProprietario)) &&
                (!filtro.Codigo.HasValue || s.Id == filtro.Codigo) &&
                (!filtro.Status.HasValue || s.Status == filtro.Status) &&
                (!filtro.DataSolicitacao.HasValue || s.DataVistoria >= filtro.DataSolicitacao.Value.Date) &&
                (!filtro.DataAgendamento.HasValue || s.DataVistoria < filtro.DataAgendamento.Value.Date) &&
                (string.IsNullOrEmpty(filtro.EnderecoRua) || s.Rua == filtro.EnderecoRua) &&
                filtro.IdUsuario == s.IdSolicitador
                ).ToList();

                return _mapper.Map<IEnumerable<ViewSolicitacaoVO>>(lstSolicitacao);
            }
            else
            {
                IEnumerable<ViewSolicitacao> lstSolicitacao = _context.ViewSolicitacao.Where(s =>
                (string.IsNullOrEmpty(filtro.NomeVistoriador) || s.NomeVistoriador.Contains(filtro.NomeVistoriador)) &&
                (string.IsNullOrEmpty(filtro.NomeProprietario) || s.NomeVistoriador.Contains(filtro.NomeProprietario)) &&
                (!filtro.Codigo.HasValue || s.Id == filtro.Codigo) &&
                (!filtro.Status.HasValue || s.Status == filtro.Status) &&
                (!filtro.DataSolicitacao.HasValue || s.DataVistoria >= filtro.DataSolicitacao.Value.Date) &&
                (!filtro.DataAgendamento.HasValue || s.DataVistoria < filtro.DataAgendamento.Value.Date) &&
                (string.IsNullOrEmpty(filtro.EnderecoRua) || s.Rua == filtro.EnderecoRua) &&
                filtro.IdUsuario == s.IdVistoriador
                ).ToList();

                return _mapper.Map<IEnumerable<ViewSolicitacaoVO>>(lstSolicitacao);
            } 
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

        public void InserirVistoria(VistoriaVO vistoriaVO)
        {
            Vistoria vistoria = _mapper.Map<Vistoria>(vistoriaVO);
            _context.Vistoria.Add(vistoria);
            _context.SaveChanges();
        }

        #region Comodo
        public void InserirComodo(ComodoVO comodoVO)
        {
            Comodo comodo = _mapper.Map<Comodo>(comodoVO);
            _context.Comodo.Add(comodo);
            _context.SaveChanges();
        }
        public IEnumerable<ViewComodoVO> BuscarViewComodo(int idVistoria)
        {
            IEnumerable<ViewComodo> lstComodo =  _context.ViewComodo.Where(c => c.IdVistoria == idVistoria).ToList();
            return _mapper.Map<IEnumerable<ViewComodoVO>>(lstComodo);
        }
        #endregion

        #region Nota
        public void InserirNota(NotaVO notaVO)
        {
            Nota nota = _mapper.Map<Nota>(notaVO);
            _context.Nota.Add(nota);
            _context.SaveChanges();
        }
        public IEnumerable<ViewNotaVO> BuscarViewNota(int idComodo)
        {
            IEnumerable<ViewNota> lstViewNota = _context.ViewNota.Where(v => v.IdComodo == idComodo).ToList();
            return _mapper.Map<IEnumerable<ViewNotaVO>>(lstViewNota);
        }
        #endregion

        public void InserirMedicao(MedicaoVO medicaoVO)
        {
            Medicao medicao = _mapper.Map<Medicao>(medicaoVO);
            _context.Medicao.Add(medicao);
            _context.SaveChanges();
        }


        #endregion

        #region Metodos de Teste
        public IList<SolicitacaoVO> FindAll()
        {
            IList<Solicitacao> lstSolicitacao = _context.Solicitacao.ToList();
            return _mapper.Map<IList<SolicitacaoVO>>(lstSolicitacao);
        }
        #endregion

        #endregion
    }
}
