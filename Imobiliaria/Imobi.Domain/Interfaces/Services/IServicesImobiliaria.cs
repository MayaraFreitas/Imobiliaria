using Imobi.Domain.VOs;
using System;

namespace Imobi.Domain.Interfaces.Services
{
    public interface IServicesImobiliaria
    {
        string  Autenticar(string email, string senha);

        Guid AdicionarUsuario(Nome nome, string email, string senha);
    }
}
