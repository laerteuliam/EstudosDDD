//[assembly: WebActivator.PostApplicationStartMethod(typeof(EstudosDDD.UI.Web.), "Initialize")]

using System.Reflection;
using System.Web.Mvc;
using EstudosDDD.Infra.CrossCutting.Ioc;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace EstudosDDD.UI.Web.App_Start
{
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            // Did you know the container can diagnose your configuration? 
            // Go to: https://simpleinjector.org/diagnostics
            var container = new Container();

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            IocStartUp.BootStrap(container, new WebRequestLifestyle());
        }
    }
}