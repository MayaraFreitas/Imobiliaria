using AutoMapper;
using Imobi.Controllers.DTOs;
using Imobi.Models.ViewModels.Vistoria;
using Imobi.Repository.Entities;
using Imobi.Services.VOs.Vistoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobi.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<VistoriaVO, Vistoria>().ReverseMap();
            CreateMap<VistoriaDTO, VistoriaVO>().ReverseMap();
            CreateMap<VistoriaVM, VistoriaDTO>().ReverseMap();
        }
    }
}
