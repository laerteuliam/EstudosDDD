using EstudosDDD.Infra.CrossCutting.Ioc.Extensions;
using EstudosDDD.Domain.Services;
using SimpleInjector;

namespace EstudosDDD.Infra.CrossCutting.Ioc.Containers
{
    public static class DomainServiceContainer
    {
        public static void RegisterDomainService(this Container container)
        {
            container.BatchRegister<PessoaDomainService>();
            container.BatchRegister<LoginDomainService>();
        }
    }
}
