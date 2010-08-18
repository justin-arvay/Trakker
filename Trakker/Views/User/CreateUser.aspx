﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ViewWrapperViewData<MasterViewData,Trakker.ViewData.UserData.CreateEditUserViewData>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CreateUser
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<% using (Html.BeginForm())
   { %>
    <h2>CreateUser</h2>
    <%= Html.LabelFor(x => x.View.Email)%>
    <%= Html.TextBox("Email", Model.View.Email)%>

    <%= Html.LabelFor(x => x.View.Password)%>
    <%= Html.TextBox("Password", Model.View.Password)%>

    <%= Html.LabelFor(x => x.View.RePassword)%>
    <%= Html.TextBox("RePassword", Model.View.RePassword)%>

    <%= Html.LabelFor(x=>x.View.Roles) %>
    <%= Html.DropDownList("RoleId", new SelectList(Model.View.Roles, "RoleId", "Name", Model.View.RoleId )) %>

    <%= Html.SaveButton("Save", Relation.Single, Icon.Save, new { type = "submit" })%>
<% } %>
</asp:Content>
