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
        IList<SolicitacaoVO> FindAll();
    }
    public class VistoriaRepository : IVistoriaRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public VistoriaRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void InserirSolicitacao(SolicitacaoVO solicitacaoVO)
        {
            Solicitacao solicitacao = _mapper.Map<Solicitacao>(solicitacaoVO);
            _context.Solicitacao.Add(solicitacao);
            _context.SaveChanges();
        }

        public IList<SolicitacaoVO> FindAll()
        {
            IList<Solicitacao> lstSolicitacao = _context.Solicitacao.ToList();
            return _mapper.Map<IList<SolicitacaoVO>>(lstSolicitacao);
        }
    }
}
