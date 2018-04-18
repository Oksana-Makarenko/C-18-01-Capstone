using System.Web.Mvc;
using System.Web.Routing;

namespace C_18_01_Capstone.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
      
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                    name: "UserSignUp",
                    url: "{controller}/{action}",
                    defaults: new { controller = "User", action = "SignUp"}
            );

            routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
