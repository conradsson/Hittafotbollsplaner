﻿using System;
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

            routes.MapRoute(name: "Start", url: "", defaults: new { controller = "Home", action = "Index" });
            routes.MapRoute(name: "Lägg till fotbollsplan", url: "laggtillfotbollsplan", defaults: new { controller = "fotbollsplaners", action = "Create" });
            routes.MapRoute(name: "Om", url: "omoss", defaults: new { controller = "Home", action = "Om" });
            routes.MapRoute(name: "Kontakt", url: "kontakt", defaults: new { controller = "Home", action = "Kontakt" });
            routes.MapRoute(name: "Aktuellfotbollsplan", url: "Fotbollsplan/{id}", defaults: new { controller = "Fotbollsplan", action = "Planid"});

            
            routes.MapRoute(name: "Login", url: "admin", defaults: new { controller = "Account", action = "Login" });
            routes.MapRoute(name: "LogOff", url: "logoff", defaults: new { controller = "Account", action = "LoggaUt" });
            routes.MapRoute(name: "Manage", url: "man", defaults: new { controller = "Manage", action = "Index" });
            routes.MapRoute(name: "ChangePass", url: "man/andralosen", defaults: new { controller = "Manage", action = "ChangePassword" });
            routes.MapRoute(name: "Editering", url: "editering", defaults: new { controller = "fotbollsplaners", action = "Index" });
            routes.MapRoute(name: "Register", url: "reg", defaults: new { controller = "Account", action = "Register" });
            routes.MapRoute(name: "AdminEdit", url: "admin/edit/{id}", defaults: new { controller = "fotbollsplaners", action = "Edit" });
            routes.MapRoute(name: "AdminMerinfo", url: "admin/merinfo/{id}", defaults: new { controller = "fotbollsplaners", action = "Details" });
            routes.MapRoute(name: "AdminDelete", url: "admin/delete/{id}", defaults: new { controller = "fotbollsplaners", action = "Delete" });

        }
    }
}
