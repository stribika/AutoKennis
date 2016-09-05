<%@ Control Language="C#" Inherits="AdminPortal.FormField" %>
<label for="<%= textBox.ClientID %>"><%= HttpUtility.HtmlEncode(Label)  %></label>
<div class="input-group">
	<% if (Glyphicon != null && Glyphicon != "") { %>
		<span class="input-group-addon">
			<asp:Label id="glyph" aria-hidden="true" runat="server"/>
		</span>
	<% } else if (Prefix != null && Prefix != "") { %>
		<asp:Label id="prefix" CssClass="input-group-addon" runat="server"/>
	<% } %>
	<asp:TextBox id="textBox" CssClass="form-control" runat="server"/>
</div>
