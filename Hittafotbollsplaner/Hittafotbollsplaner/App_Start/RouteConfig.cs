using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hittafotbollsplaner
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(name: "Default",url: "{controller}/{id}",defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
            routes.MapRoute(name: "Start", url: "", defaults: new { controller = "Home", action = "Index" });
            routes.MapRoute(name: "Lägg till fotbollsplan", url: "laggtillfotbollsplan", defaults: new { controller = "fotbollsplaners", action = "Create" });
            routes.MapRoute(name: "Om", url: "omoss", defaults: new { controller = "Home", action = "Om" });
            routes.MapRoute(name: "Kontakt", url: "kontakt", defaults: new { controller = "Home", action = "Kontakt" });
            routes.MapRoute(name: "Aktuellfotbollsplan", url: "Fotbollsplan/{id}", defaults: new { controller = "Fotbollsplan", action = "Planid"});

            routes.MapRoute(name: "Login", url: "login", defaults: new { controller = "Account", action = "Register" });
            routes.MapRoute(name: "Admin", url: "admin", defaults: new { controller = "fotbollsplaners", action = "Index" });
            routes.MapRoute(name: "AdminEdit", url: "admin/edit/{id}", defaults: new { controller = "fotbollsplaners", action = "Edit" });
            routes.MapRoute(name: "AdminMerinfo", url: "admin/merinfo/{id}", defaults: new { controller = "fotbollsplaners", action = "Details" });
            routes.MapRoute(name: "AdminDelete", url: "admin/delete/{id}", defaults: new { controller = "fotbollsplaners", action = "Delete" });
        }
    }
}
