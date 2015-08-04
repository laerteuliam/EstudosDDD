using CrossCutting.Ioc.Extensions;
using EstudosDDD.Data.Repositories;
using SimpleInjector;

namespace CrossCutting.Ioc.Containers
{
    public static class RepositoryContainer
    {
        public static void RegisterRepository(this Container container)
        {
            container.BatchRegister<PessoaRepository>();
            container.BatchRegister<LoginRepository>();
        }
    }
}
