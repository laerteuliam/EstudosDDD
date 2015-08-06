using System;
using System.Collections.Generic;
using System.Linq;
using EstudosDDD.Infra.CrossCutting.Ioc.Extensions;
using EstudosDDD.Application.Contracts;
using EstudosDDD.Application.Services;
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
