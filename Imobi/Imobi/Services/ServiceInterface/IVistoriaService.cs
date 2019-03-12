using Imobi.Controllers.DTOs;
using System.Collections.Generic;

namespace Imobi.Services.ServiceInterface
{
    public interface IVistoriaService
    {
        IEnumerable<VistoriaDTO> FindAll();
        void InserirVistoria(VistoriaDTO vistoria);
    }
}
