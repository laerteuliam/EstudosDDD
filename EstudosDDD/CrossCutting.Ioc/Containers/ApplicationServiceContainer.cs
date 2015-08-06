using EstudosDDD.Application.Services;
using EstudosDDD.Infra.CrossCutting.Ioc.Extensions;
using SimpleInjector;

namespace EstudosDDD.Infra.CrossCutting.Ioc.Containers
{
    public static class ApplicationServiceContainer
    {
        public static void RegisterApplicationService(this Container container)
        {
            container.BatchRegister<PessoaApplicationService>();
        }
    }
}