using AutoMapper;
using Imobiliaria.Data.Entities;
using Imobiliaria.Service.VOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Data.Reporsitory
{
    public interface IClienteRepository
    {
        void InserirSolicitacao(SolicitacaoVO solicitacao);
        IList<SolicitacaoVO> FindAll();
    }
    public class ClienteRepository
    {
    }
}
