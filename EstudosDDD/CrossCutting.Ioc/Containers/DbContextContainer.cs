using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCutting.Ioc.Extensions;
using EstudosDDD.Data.Contexts;
using SimpleInjector;

namespace CrossCutting.Ioc.Containers
{
    public static class DbContextContainer
    {
        public static void RegisterDbContext(this Container container)
        {
            container.BatchRegister<EstudosDbContext>();
        }
    }
}
