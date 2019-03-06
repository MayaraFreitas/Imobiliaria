using Imobi.Domain.Interfaces.Repositories;
using Imobi.Domain.Interfaces.Services;
using Imobi.Domain.Services;
using Imobi.Infra.Persistence;
using Imobi.Infra.Persistence.Repositories;
using Imobi.Infra.Transaction;
using prmToolkit.NotificationPattern;
using System.Data.Entity;
using Unity;
using Unity.Lifetime;

namespace Imobi.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType <DbContext, ImobiContext> (new HierarchicalLifetimeManager());

            // UnityOfWork
            container.RegisterType <IUnitOfWork, UnitOfWork> (new HierarchicalLifetimeManager());
            container.RegisterType <INotifiable, Notifiable> (new HierarchicalLifetimeManager());

            // Services
            container.RegisterType <IUsuarioService, UsuarioService> (new HierarchicalLifetimeManager());

            // Repositories
            container.RegisterType <IUsuarioRepository, UsuarioRepository> (new HierarchicalLifetimeManager());
        }
    }
}
