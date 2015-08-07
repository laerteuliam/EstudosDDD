using EstudosDDD.Data.Repositories;
using EstudosDDD.Infra.CrossCutting.Ioc.Extensions;
using SimpleInjector;

namespace EstudosDDD.Infra.CrossCutting.Ioc.Containers
{
    public static class RepositoryContainer
    {
        public static void RegisterRepository(this Container container)
        {
            container.BatchRegister<PessoaRepository>();
        }
    }
}