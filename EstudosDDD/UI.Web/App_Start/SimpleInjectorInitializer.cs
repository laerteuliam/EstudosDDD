//[assembly: WebActivator.PostApplicationStartMethod(typeof(Ezconet.GerenciamentoProjetos.UI.Web.App_Start.SimpleInjectorInitializer), "Initialize")]
using System.Reflection;
using System.Web.Mvc;
using SimpleInjector;
using SimpleInjector.Extensions;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using EstudosDDD.Infra.CrossCutting.Ioc;


namespace UI.Web.App_Start
{
    //using EzconetDDD.Data.Infra.CrossCutting.IoC;
    
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
           // IoCStartUp.Bootstrap(container, new WebRequestLifestyle());
        }
    }
}