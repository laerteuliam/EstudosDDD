using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EstudosDDD.UI.Web.App_Start;

namespace EstudosDDD.UI.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}