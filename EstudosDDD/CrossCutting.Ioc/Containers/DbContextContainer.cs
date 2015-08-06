using EstudosDDD.Data.Contexts;
using EstudosDDD.Infra.CrossCutting.Ioc.Extensions;
using SimpleInjector;

namespace EstudosDDD.Infra.CrossCutting.Ioc.Containers
{
    public static class DbContextContainer
    {
        public static void RegisterDbContext(this Container container)
        {
            container.BatchRegister<EstudosDbContext>();
        }
    }
}