﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Admin/Views/Shared/Admin.master" Inherits="System.Web.Mvc.ViewPage<BrowseColorPalettesModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="Section">
        <h1>Browse Color Palettes</h1>
        <p>In the table below is all the available color palettes for the system.</p>
        <p><%: Html.ActionLink("Add", MVC.Admin.Settings.CreateColorPalette()) %> new color palettes.</p>
    </div>

    <table class="Grid Indent" id="ColorPalettes">
        <thead>
            <tr>
                <th>Name</th>
                <th>Navigation Background Color</th>
                <th>Navigation Text Color</th>
                <th>Sub-navigation Background Color</th>
                <th>Sub-navigation Text Color</th>
                <th>Highlight Color</th>
                <th>Link Color</th>
                <th>Operation</th>
            </tr>
        </thead>
        <tbody>
            <% foreach(var palette in Model.ColorPalettes) { %>
                <tr>
                    <td>
                        <strong><%: palette.Name %></strong>
                        <% if (Model.SelectedColorPalette.Id == palette.Id) { %>                                                  
                            (Selected)
                        <% } %>                        
                    </td>
                    <td>
                        <div style="background-color: #<%: palette.NavBackgroundColor %>"></div>
                        #<%: palette.NavBackgroundColor %> 
                    </td>
                    <td>
                        <div style="background-color: #<%: palette.NavTextColor %>"></div>
                        #<%: palette.NavTextColor %>
                    </td>
                    <td>
                        <div style="background-color: #<%: palette.SubNavBackgroundColor %>"></div>
                        #<%: palette.SubNavBackgroundColor %>
                    </td>
                    <td>
                        <div style="background-color: #<%: palette.SubNavTextColor %>"></div>
                        #<%: palette.SubNavTextColor %>
                    </td>
                    <td>
                        <div style="background-color: #<%: palette.HighlightColor %>"></div>
                        #<%: palette.HighlightColor %>
                    </td>
                    <td>
                        <div style="background-color: #<%: palette.LinkColor %>"></div>
                        #<%: palette.LinkColor %>
                    </td>
                    <td>
                        <%: Html.ActionLink("Edit", MVC.Admin.Settings.EditColorPalette(palette.Id)) %> 
                        
                        <% if (Model.SelectedColorPalette.Id != palette.Id) { %>                                                  
                            | <%= Html.ActionLink("Select", MVC.Admin.Settings.SelectColorPalette(palette.Id))%>
                        <% } %>
                    </td>
                </tr>
            <% } %>        
        </tbody>
    </table>

</asp:Content>
