using System.Web.Mvc;
using System.Web.Routing;

namespace kgetechnologies.com
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.RouteExistingFiles = true;

               routes.IgnoreRoute("");

            routes.MapRoute(
             name: "Defaulta",
             url: "{id}",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
         );
            routes.MapRoute(
     name: "Defaultc",
     url: "sitemap/{id}.xml",
     defaults: new { controller = "sitemap", action = "Index", id = UrlParameter.Optional }
 );


            routes.MapRoute(
             name: "Defaultb",
             url: "sitemap/{id}",
             defaults: new { controller = "sitemap", action = "Index", id = UrlParameter.Optional }
         );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
