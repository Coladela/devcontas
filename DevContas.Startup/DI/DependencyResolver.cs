using DevContas.Domain;
using DevContas.Domain.Contracts.Repositories;
using DevContas.Domain.Contracts.Services;
using DevContas.Domain.Validation;
using DevContas.Domain.Validation.Contracts;
using DevContas.Infra.Data.Contexts;
using DevContas.Infra.Repositories;
using DevContas.Service;
using Microsoft.Practices.Unity;

namespace DevContas.Startup.DI
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<DevContasDataContext, DevContasDataContext>(new HierarchicalLifetimeManager());

            container.RegisterType<IValidator<User>, UserValidator>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager());            
        }
    }
}
