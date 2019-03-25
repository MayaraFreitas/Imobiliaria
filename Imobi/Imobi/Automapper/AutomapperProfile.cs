using AutoMapper;
using Imobi.Controllers.DTOs;
using Imobi.Models.ViewModels.Usuario;
using Imobi.Models.ViewModels.Vistoria;
using Imobi.Repository.Entities;
using Imobi.Services.VOs.Account;
using Imobi.Services.VOs.Usuario;
using Imobi.Services.VOs.Vistoria;

namespace Imobi.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<VistoriaVO, Vistoria>().ReverseMap();
            CreateMap<VistoriaDTO, VistoriaVO>().ReverseMap();
            CreateMap<VistoriaVM, VistoriaDTO>().ReverseMap();

            #region User

            CreateMap<UserVO, User>().ReverseMap();
            CreateMap<UserVM, UserVO>().ReverseMap();

            CreateMap<ViewUserLoginVM, ViewUserLoginVO>().ReverseMap();

            #endregion
        }
    }
}
