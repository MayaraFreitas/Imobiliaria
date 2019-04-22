using AutoMapper;
using Imobiliaria.Data.Entities;
using Imobiliaria.Service.VOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Data.Repository
{
    public interface IVistoriaRepository
    {
        void InserirSolicitacao(SolicitacaoVO solicitacao);
        SolicitacaoVO BuscarSolicitacao(SolicitacaoFiltroVO filtro);
        SolicitacaoVO BuscarSolicitacaoDetalhe(int codigoSolicitacao);

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

        public SolicitacaoVO BuscarSolicitacao(SolicitacaoFiltroVO filtro)
        {
            return null;
        }

        public SolicitacaoVO BuscarSolicitacaoDetalhe(int codigoSolicitacao)
        {
            Solicitacao solicitacao = _context.Solicitacao.Find(codigoSolicitacao);
            return _mapper.Map<SolicitacaoVO>(solicitacao);
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
