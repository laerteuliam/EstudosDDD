using EstudosDDD.Infra.CrossCutting.Ioc.Containers;
using SimpleInjector;

namespace EstudosDDD.Infra.CrossCutting.Ioc
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