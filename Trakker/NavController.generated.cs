// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Trakker.Controllers {
    public partial class NavController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public NavController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected NavController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Pagination() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Pagination);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public NavController Actions { get { return MVC.Nav; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "nav";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Pagination = ("Pagination").ToLowerInvariant();
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Pagination = "~/Views/Nav/Pagination.ascx";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_NavController: Trakker.Controllers.NavController {
        public T4MVC_NavController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Pagination(int count, int page, int pageSize) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Pagination);
            callInfo.RouteValueDictionary.Add("count", count);
            callInfo.RouteValueDictionary.Add("page", page);
            callInfo.RouteValueDictionary.Add("pageSize", pageSize);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
