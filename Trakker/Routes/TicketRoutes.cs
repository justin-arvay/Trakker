﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Trakker.Routes
{
    public static class TicketRoutes
    {
        public static void AddRoutes(ref RouteCollection routes)
        {
            routes.MapRoute("CreateTicket", "new", new { controller = "Ticket", action = "CreateTicket" });
            routes.MapRoute("EditTicket", "edit/{keyName}", new { controller = "Ticket", action = "EditTicket" });
            routes.MapRoute("TicketDetails", "{keyName}", new { controller = "Ticket", action = "TicketDetails" });
            routes.MapRoute("CreateComment", "{keyName}/comment", new { controller = "Ticket", action = "CreateComment" });
            routes.MapRoute("EditComment", "{keyName}/comment/edit/{id}", new { controller = "Ticket", action = "EditComment" });


        }
    }
}