using Imobi.Models.ViewModels.Vistoria;
using System.Collections.Generic;

namespace Imobi.Services.ServiceInterface
{
    public interface IVistoriaService
    {
        List<Vistoria> FindAll();
        void InserirVistoria(Vistoria vistoria);
    }
}
