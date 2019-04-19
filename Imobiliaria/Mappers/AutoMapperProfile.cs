using AutoMapper;
using Imobiliaria.Data.Entities;
using Imobiliaria.Models;
using Imobiliaria.Service.VOs;
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
        }
    }
}
