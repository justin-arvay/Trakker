<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Basic.Master" Inherits="System.Web.Mvc.ViewPage<CreateEditTicketModel>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="BasicContent" runat="server">
<% using (Html.BeginForm())
   {%>
    <h1>Ticket: <%= Model.KeyName %></h1>
    <% Html.RenderPartial("CreateEditticketForm", Model); %>
<% }  %>

</asp:Content>
