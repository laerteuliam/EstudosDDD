using EstudosDDD.Infra.CrossCutting.Ioc.Containers;
using Microsoft.Practices.ServiceLocation;
using SimpleInjector;

namespace EstudosDDD.Infra.CrossCutting.Ioc
{
    public static class IoCStartUp
    {
        public static void BootStrap(Container container, Lifestyle lifestyle)
        {
            container.RegisterDbContext(lifestyle);

            container.RegisterApplicationService();
            container.RegisterDomainService();
            container.RegisterRepository();
            container.RegisterUnityOfWork();

            ServiceLocator.SetLocatorProvider(() => new Adapters.SimpleInjectorServiceLocatorAdapter(container));
        }
    }
}