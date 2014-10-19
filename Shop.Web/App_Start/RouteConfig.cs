using System.Web.Mvc;
using System.Web.Routing;

namespace Shop.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("test",
                "Product/{id}",
                new { controller = "Product", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}
                );
        }
    }
}