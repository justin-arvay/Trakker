<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IList<Trakker.Data.Comment>>" %>

<ul>
    <% foreach(var comment in Model) { %>
        <li class="Comment">
            <img src="../../Content/Images/TestTicketIcon.png" width="16" height="16" />
            <p><strong><%: Html.ActionLink(comment.User.FullName(), MVC.User.UserProfile(comment.User.Id)) %></strong> commented on <strong><%: comment.Created.Date.ToShortDateString() %></strong> at <strong><%: comment.Created.TimeOfDay %></strong> saying:</p>
            <div><%: comment.Body%></div>
        </li>
    <% } %>
</ul>
<%= Html.LinkButton("Comment", Relation.Single, null, new { })%>

