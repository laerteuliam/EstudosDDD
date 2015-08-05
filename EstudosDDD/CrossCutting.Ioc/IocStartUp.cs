using CrossCutting.Ioc.Containers;
using SimpleInjector;

namespace CrossCutting.Ioc
{
    public static class IocStartUp
    {
        public static void BootStrap(Container container, Lifestyle lifestyle)
        {
            container.RegisterApplicationService();
            container.RegisterDbContext();
            container.RegisterDomainService();
            container.RegisterRepository();
            container.RegisterUnityOfWork();
        }
    }
}
