using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
