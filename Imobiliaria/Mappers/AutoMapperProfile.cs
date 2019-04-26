using AutoMapper;
using Imobiliaria.Data.Entities;
using Imobiliaria.Models;
using Imobiliaria.Models.Solicitacao;
using Imobiliaria.Service.VOs;
using Imobiliaria.Service.VOs.Solicitacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Solicitacao, SolicitacaoVO>().ReverseMap();
            CreateMap<SolicitacaoVO, SolicitacaoVM>().ReverseMap();
            CreateMap<SolicitacaoFiltroVO, SolicitacaoFiltroVM>().ReverseMap();
            CreateMap<ViewSolicitacao, ViewSolicitacaoVO>().ReverseMap();
            CreateMap<ViewSolicitacaoVO, ViewSolicitacaoVM>().ReverseMap();
            /*
            CreateMap<Cliente, ClienteVO>().ReverseMap();
            CreateMap<ClienteVO, ClienteVM>().ReverseMap();

            CreateMap<Comodo, ComodoVO>().ReverseMap();
            CreateMap<ComodoVO, ComodoVM>().ReverseMap();

            CreateMap<Empresa, EmpresaVO>().ReverseMap();
            CreateMap<EmpresaVO, EmpresaVM>().ReverseMap();

            CreateMap<Endereco, EnderecoVO>().ReverseMap();
            CreateMap<EnderecoVO, EnderecoVM>().ReverseMap();

            CreateMap<Imovel, ImovelVO>().ReverseMap();
            CreateMap<ImovelVO, ImovelVM>().ReverseMap();

            CreateMap<LogSolicitacao, LogSolicitacaoVO>().ReverseMap();
            CreateMap<LogSolicitacaoVO, LogSolicitacaoVM>().ReverseMap();

            CreateMap<Medicao, MedicaoVO>().ReverseMap();
            CreateMap<MedicaoVO, MedicaoVM>().ReverseMap();

            CreateMap<Nota, NotaVO>().ReverseMap();
            CreateMap<NotaVO, NotaVM>().ReverseMap();

            CreateMap<User, UserVO>().ReverseMap();
            CreateMap<UserVO, UserVM>().ReverseMap();

            CreateMap<Vistoria, VistoriaVO>().ReverseMap();
            CreateMap<VistoriaVO, VistoriaVM>().ReverseMap();
            */
        }
    }
}
