﻿// <auto-generated />
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

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static class MVC {
    static readonly AdminClass s_Admin = new AdminClass();
    public static AdminClass Admin { get { return s_Admin; } }
    public static Trakker.Controllers.NavController Nav = new Trakker.Controllers.T4MVC_NavController();
    public static Trakker.Controllers.ProjectController Project = new Trakker.Controllers.T4MVC_ProjectController();
    public static Trakker.Controllers.ResourceController Resource = new Trakker.Controllers.T4MVC_ResourceController();
    public static Trakker.Controllers.TicketController Ticket = new Trakker.Controllers.T4MVC_TicketController();
    public static Trakker.Controllers.UserController User = new Trakker.Controllers.T4MVC_UserController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class AdminClass {
        public readonly string Name = "admin";
        public Trakker.Areas.Admin.Controllers.AttributeController Attribute = new Trakker.Areas.Admin.Controllers.T4MVC_AttributeController();
        public Trakker.Areas.Admin.Controllers.ManagementController Management = new Trakker.Areas.Admin.Controllers.T4MVC_ManagementController();
        public Trakker.Areas.Admin.Controllers.SettingsController Settings = new Trakker.Areas.Admin.Controllers.T4MVC_SettingsController();
        public T4MVC.Admin.SharedController Shared = new T4MVC.Admin.SharedController();
    }
}

namespace System.Web.Mvc {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class T4Extensions {
        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result) {
            return htmlHelper.RouteLink(linkText, result.GetRouteValueDictionary());
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, object htmlAttributes) {
            return ActionLink(htmlHelper, linkText, result, new RouteValueDictionary(htmlAttributes));
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, IDictionary<string, object> htmlAttributes) {
            return htmlHelper.RouteLink(linkText, result.GetRouteValueDictionary(), htmlAttributes);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod) {
            return htmlHelper.BeginForm(result, formMethod, null);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod, object htmlAttributes) {
            return BeginForm(htmlHelper, result, formMethod, new RouteValueDictionary(htmlAttributes));
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod, IDictionary<string, object> htmlAttributes) {
            var callInfo = result.GetT4MVCResult();
            return htmlHelper.BeginForm(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary, formMethod, htmlAttributes);
        }

        public static void RenderAction(this HtmlHelper htmlHelper, ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            htmlHelper.RenderAction(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary);
        }

        public static MvcHtmlString Action(this HtmlHelper htmlHelper, ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return htmlHelper.Action(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary);
        }
        public static string Action(this UrlHelper urlHelper, ActionResult result) {
            return urlHelper.RouteUrl(result.GetRouteValueDictionary());
        }

        public static string ActionAbsolute(this UrlHelper urlHelper, ActionResult result) {
            return string.Format("{0}{1}",urlHelper.RequestContext.HttpContext.Request.Url.GetLeftPart(UriPartial.Authority),
                urlHelper.RouteUrl(result.GetRouteValueDictionary()));
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions) {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions);
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions, object htmlAttributes) {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions, new RouteValueDictionary(htmlAttributes));
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes) {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions, htmlAttributes);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result) {
            return MapRoute(routes, name, url, result, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults) {
            return MapRoute(routes, name, url, result, defaults, null /*constraints*/, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, string[] namespaces) {
            return MapRoute(routes, name, url, result, null /*defaults*/, namespaces);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, object constraints) {
            return MapRoute(routes, name, url, result, defaults, constraints, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, string[] namespaces) {
            return MapRoute(routes, name, url, result, defaults, null /*constraints*/, namespaces);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, object constraints, string[] namespaces) {
            // Create and add the route
            var route = CreateRoute(url, result, defaults, constraints, namespaces);
            routes.Add(name, route);
            return route;
        }

        // Note: can't name the AreaRegistrationContext methods 'MapRoute', as that conflicts with the existing methods
        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result) {
            return MapRouteArea(context, name, url, result, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults) {
            return MapRouteArea(context, name, url, result, defaults, null /*constraints*/, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, string[] namespaces) {
            return MapRouteArea(context, name, url, result, null /*defaults*/, namespaces);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, object constraints) {
            return MapRouteArea(context, name, url, result, defaults, constraints, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, string[] namespaces) {
            return MapRouteArea(context, name, url, result, defaults, null /*constraints*/, namespaces);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, object constraints, string[] namespaces) {
            // Create and add the route
            var route = CreateRoute(url, result, defaults, constraints, namespaces);
            context.Routes.Add(name, route);
            route.DataTokens["area"] = context.AreaName;
            return route;
        }

        private static Route CreateRoute(string url, ActionResult result, object defaults, object constraints, string[] namespaces) {
            // Start by adding the default values from the anonymous object (if any)
            var routeValues = new RouteValueDictionary(defaults);

            // Then add the Controller/Action names and the parameters from the call
            foreach (var pair in result.GetRouteValueDictionary()) {
                routeValues.Add(pair.Key, pair.Value);
            }

            var routeConstraints = new RouteValueDictionary(constraints);

            // Create and add the route
            var route = new Route(url, routeValues, routeConstraints, new MvcRouteHandler());

            route.DataTokens = new RouteValueDictionary();

            if (namespaces != null && namespaces.Length > 0) {
                route.DataTokens["Namespaces"] = namespaces;
            }

            return route;
        }

        public static IT4MVCActionResult GetT4MVCResult(this ActionResult result) {
            var t4MVCResult = result as IT4MVCActionResult;
            if (t4MVCResult == null) {
                throw new InvalidOperationException("T4MVC was called incorrectly. You may need to force it to regenerate by right clicking on T4MVC.tt and choosing Run Custom Tool");
            }
            return t4MVCResult;
        }

        public static RouteValueDictionary GetRouteValueDictionary(this ActionResult result) {
            return result.GetT4MVCResult().RouteValueDictionary;
        }

        public static ActionResult AddRouteValues(this ActionResult result, object routeValues) {
            return result.AddRouteValues(new RouteValueDictionary(routeValues));
        }

        public static ActionResult AddRouteValues(this ActionResult result, RouteValueDictionary routeValues) {
            RouteValueDictionary currentRouteValues = result.GetRouteValueDictionary();

            // Add all the extra values
            foreach (var pair in routeValues) {
                currentRouteValues.Add(pair.Key, pair.Value);
            }

            return result;
        }

        public static ActionResult AddRouteValues(this ActionResult result, System.Collections.Specialized.NameValueCollection nameValueCollection) {
            // Copy all the values from the NameValueCollection into the route dictionary
            nameValueCollection.CopyTo(result.GetRouteValueDictionary());
            return result;
        }

        public static ActionResult AddRouteValue(this ActionResult result, string name, object value) {
            RouteValueDictionary routeValues = result.GetRouteValueDictionary();
            routeValues.Add(name, value);
            return result;
        }
        
        public static void InitMVCT4Result(this IT4MVCActionResult result, string area, string controller, string action) {
            result.Controller = controller;
            result.Action = action;
            result.RouteValueDictionary = new RouteValueDictionary();
            result.RouteValueDictionary.Add("Area", area ?? ""); 
            result.RouteValueDictionary.Add("Controller", controller);
            result.RouteValueDictionary.Add("Action", action);
        }

        public static bool FileExists(string virtualPath) {
            if (!HostingEnvironment.IsHosted) return false;
            string filePath = HostingEnvironment.MapPath(virtualPath);
            return System.IO.File.Exists(filePath);
        }

        static DateTime CenturyBegin=new DateTime(2001,1,1);
        public static string TimestampString(string virtualPath) {
            if (!HostingEnvironment.IsHosted) return string.Empty;
            string filePath = HostingEnvironment.MapPath(virtualPath);
            return Convert.ToString((System.IO.File.GetLastWriteTimeUtc(filePath).Ticks-CenturyBegin.Ticks)/1000000000,16);            
        }
    }
}

   
[GeneratedCode("T4MVC", "2.0")]   
public interface IT4MVCActionResult {   
    string Action { get; set; }   
    string Controller { get; set; }   
    RouteValueDictionary RouteValueDictionary { get; set; }   
}   
  

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult {
    public T4MVC_ActionResult(string area, string controller, string action): base()  {
        this.InitMVCT4Result(area, controller, action);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_StyleSheetResult : System.Web.Mvc.StyleSheetResult, IT4MVCActionResult {
    public T4MVC_StyleSheetResult(string area, string controller, string action): base()  {
        this.InitMVCT4Result(area, controller, action);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_JavaScriptResult : System.Web.Mvc.JavaScriptResult, IT4MVCActionResult {
    public T4MVC_JavaScriptResult(string area, string controller, string action): base()  {
        this.InitMVCT4Result(area, controller, action);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class _2010_2_825 {
            private const string URLPATH = "~/Scripts/2010.2.825";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string jquery_1_4_2_min_js = Url("jquery-1.4.2.min.js");
            public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
            public static readonly string telerik_autocomplete_min_js = Url("telerik.autocomplete.min.js");
            public static readonly string telerik_calendar_min_js = Url("telerik.calendar.min.js");
            public static readonly string telerik_combobox_min_js = Url("telerik.combobox.min.js");
            public static readonly string telerik_common_min_js = Url("telerik.common.min.js");
            public static readonly string telerik_datepicker_min_js = Url("telerik.datepicker.min.js");
            public static readonly string telerik_draganddrop_min_js = Url("telerik.draganddrop.min.js");
            public static readonly string telerik_editor_min_js = Url("telerik.editor.min.js");
            public static readonly string telerik_grid_editing_min_js = Url("telerik.grid.editing.min.js");
            public static readonly string telerik_grid_filtering_min_js = Url("telerik.grid.filtering.min.js");
            public static readonly string telerik_grid_grouping_min_js = Url("telerik.grid.grouping.min.js");
            public static readonly string telerik_grid_min_js = Url("telerik.grid.min.js");
            public static readonly string telerik_grid_resizing_min_js = Url("telerik.grid.resizing.min.js");
            public static readonly string telerik_list_min_js = Url("telerik.list.min.js");
            public static readonly string telerik_menu_min_js = Url("telerik.menu.min.js");
            public static readonly string telerik_panelbar_min_js = Url("telerik.panelbar.min.js");
            public static readonly string telerik_tabstrip_min_js = Url("telerik.tabstrip.min.js");
            public static readonly string telerik_textbox_min_js = Url("telerik.textbox.min.js");
            public static readonly string telerik_treeview_min_js = Url("telerik.treeview.min.js");
            public static readonly string telerik_window_min_js = Url("telerik.window.min.js");
        }
    
        public static readonly string jquery_1_4_1_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.4.1-vsdoc.min.js") ? Url("jquery-1.4.1-vsdoc.min.js") : Url("jquery-1.4.1-vsdoc.js");
                      
        public static readonly string jquery_1_4_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.4.1.min.js") ? Url("jquery-1.4.1.min.js") : Url("jquery-1.4.1.js");
                      
        public static readonly string jquery_1_4_1_min_js = Url("jquery-1.4.1.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
                      
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
                      
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jqueryTools_tabs_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jqueryTools.tabs.min.js") ? Url("jqueryTools.tabs.min.js") : Url("jqueryTools.tabs.js");
                      
        public static readonly string MicrosoftAjax_debug_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftAjax.debug.min.js") ? Url("MicrosoftAjax.debug.min.js") : Url("MicrosoftAjax.debug.js");
                      
        public static readonly string MicrosoftAjax_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftAjax.min.js") ? Url("MicrosoftAjax.min.js") : Url("MicrosoftAjax.js");
                      
        public static readonly string MicrosoftMvcAjax_debug_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftMvcAjax.debug.min.js") ? Url("MicrosoftMvcAjax.debug.min.js") : Url("MicrosoftMvcAjax.debug.js");
                      
        public static readonly string MicrosoftMvcAjax_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftMvcAjax.min.js") ? Url("MicrosoftMvcAjax.min.js") : Url("MicrosoftMvcAjax.js");
                      
        public static readonly string MicrosoftMvcJQueryValidation_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftMvcJQueryValidation.min.js") ? Url("MicrosoftMvcJQueryValidation.min.js") : Url("MicrosoftMvcJQueryValidation.js");
                      
        public static readonly string MicrosoftMvcValidation_debug_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftMvcValidation.debug.min.js") ? Url("MicrosoftMvcValidation.debug.min.js") : Url("MicrosoftMvcValidation.debug.js");
                      
        public static readonly string MicrosoftMvcValidation_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftMvcValidation.min.js") ? Url("MicrosoftMvcValidation.min.js") : Url("MicrosoftMvcValidation.js");
                      
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class _2010_2_825 {
            private const string URLPATH = "~/Content/2010.2.825";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Black {
                private const string URLPATH = "~/Content/2010.2.825/Black";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
                public static readonly string treeview_line_png = Url("treeview-line.png");
                public static readonly string treeview_nodes_png = Url("treeview-nodes.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Default {
                private const string URLPATH = "~/Content/2010.2.825/Default";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
                public static readonly string treeview_line_png = Url("treeview-line.png");
                public static readonly string treeview_nodes_png = Url("treeview-nodes.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Forest {
                private const string URLPATH = "~/Content/2010.2.825/Forest";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
                public static readonly string treeview_line_png = Url("treeview-line.png");
                public static readonly string treeview_nodes_png = Url("treeview-nodes.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Hay {
                private const string URLPATH = "~/Content/2010.2.825/Hay";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
                public static readonly string treeview_line_png = Url("treeview-line.png");
                public static readonly string treeview_nodes_png = Url("treeview-nodes.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Office2007 {
                private const string URLPATH = "~/Content/2010.2.825/Office2007";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
                public static readonly string treeview_line_png = Url("treeview-line.png");
                public static readonly string treeview_nodes_png = Url("treeview-nodes.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Outlook {
                private const string URLPATH = "~/Content/2010.2.825/Outlook";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
                public static readonly string treeview_line_png = Url("treeview-line.png");
                public static readonly string treeview_nodes_png = Url("treeview-nodes.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Simple {
                private const string URLPATH = "~/Content/2010.2.825/Simple";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
                public static readonly string treeview_line_png = Url("treeview-line.png");
                public static readonly string treeview_nodes_png = Url("treeview-nodes.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Sitefinity {
                private const string URLPATH = "~/Content/2010.2.825/Sitefinity";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
                public static readonly string treeview_line_png = Url("treeview-line.png");
                public static readonly string treeview_nodes_png = Url("treeview-nodes.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Sunset {
                private const string URLPATH = "~/Content/2010.2.825/Sunset";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
                public static readonly string treeview_line_png = Url("treeview-line.png");
                public static readonly string treeview_nodes_png = Url("treeview-nodes.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Telerik {
                private const string URLPATH = "~/Content/2010.2.825/Telerik";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
                public static readonly string treeview_line_png = Url("treeview-line.png");
                public static readonly string treeview_nodes_png = Url("treeview-nodes.png");
            }
        
            public static readonly string telerik_black_min_css = Url("telerik.black.min.css");
            public static readonly string telerik_common_min_css = Url("telerik.common.min.css");
            public static readonly string telerik_default_min_css = Url("telerik.default.min.css");
            public static readonly string telerik_forest_min_css = Url("telerik.forest.min.css");
            public static readonly string telerik_hay_min_css = Url("telerik.hay.min.css");
            public static readonly string telerik_office2007_min_css = Url("telerik.office2007.min.css");
            public static readonly string telerik_outlook_min_css = Url("telerik.outlook.min.css");
            public static readonly string telerik_simple_min_css = Url("telerik.simple.min.css");
            public static readonly string telerik_sitefinity_min_css = Url("telerik.sitefinity.min.css");
            public static readonly string telerik_sunset_min_css = Url("telerik.sunset.min.css");
            public static readonly string telerik_telerik_min_css = Url("telerik.telerik.min.css");
            public static readonly string telerik_vista_min_css = Url("telerik.vista.min.css");
            public static readonly string telerik_web20_min_css = Url("telerik.web20.min.css");
            public static readonly string telerik_webblue_min_css = Url("telerik.webblue.min.css");
            public static readonly string telerik_windows7_min_css = Url("telerik.windows7.min.css");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Vista {
                private const string URLPATH = "~/Content/2010.2.825/Vista";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Web20 {
                private const string URLPATH = "~/Content/2010.2.825/Web20";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
                public static readonly string treeview_line_png = Url("treeview-line.png");
                public static readonly string treeview_nodes_png = Url("treeview-nodes.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class WebBlue {
                private const string URLPATH = "~/Content/2010.2.825/WebBlue";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
                public static readonly string treeview_line_png = Url("treeview-line.png");
                public static readonly string treeview_nodes_png = Url("treeview-nodes.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Windows7 {
                private const string URLPATH = "~/Content/2010.2.825/Windows7";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string editor_png = Url("editor.png");
                public static readonly string loading_gif = Url("loading.gif");
                public static readonly string sprite_png = Url("sprite.png");
            }
        
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Admin {
            private const string URLPATH = "~/Content/Admin";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string Settings_css = Url("Settings.css");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Images {
            private const string URLPATH = "~/Content/Images";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string Background_png = Url("Background.png");
            public static readonly string Field_Background_bmp = Url("Field-Background.bmp");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Icons {
                private const string URLPATH = "~/Content/Images/Icons";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string binocular_png = Url("binocular.png");
                public static readonly string comment_add_png = Url("comment_add.png");
                public static readonly string disk__plus_png = Url("disk--plus.png");
                public static readonly string highlighter__arrow_png = Url("highlighter--arrow.png");
                public static readonly string user__arrow_png = Url("user--arrow.png");
                public static readonly string user_silhouette_question_png = Url("user-silhouette-question.png");
            }
        
            public static readonly string Icons_png = Url("Icons.png");
            public static readonly string TableBackgrounds_png = Url("TableBackgrounds.png");
            public static readonly string TestTicketIcon_png = Url("TestTicketIcon.png");
            public static readonly string UI_Backgrounds_png = Url("UI-Backgrounds.png");
            public static readonly string UI_Button_png = Url("UI-Button.png");
        }
    
        public static readonly string Main_css = Url("Main.css");
        public static readonly string Project_css = Url("Project.css");
        public static readonly string Theme_css = Url("Theme.css");
        public static readonly string Ticket_css = Url("Ticket.css");
    }

}

static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;


    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}




namespace T4MVC {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

	

#endregion T4MVC
#pragma warning restore 1591


