using EstudosDDD.Infra.CrossCutting.Ioc.Containers;
using Microsoft.Practices.ServiceLocation;
using SimpleInjector;

namespace EstudosDDD.Infra.CrossCutting.Ioc
{
    public static class IocStartUp
    {
        public static void BootStrap(Container container, Lifestyle lifestyle)
        {
            container.RegisterDbContext(lifestyle);
            
            container.RegisterRepository();
            container.RegisterDomainService();
            container.RegisterApplicationService();
            container.RegisterUnityOfWork();

            ServiceLocator.SetLocatorProvider(() => new Adapters.SimpleInjectorServiceLocatorAdapter(container));
        }
    }
}