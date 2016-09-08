<%@ Control Language="C#" Inherits="AdminPortal.FormListPanel" %>
<div class="panel panel-default">
	<div class="panel-heading"><%= HttpUtility.HtmlEncode(Heading) %></div>
	<div class="panel-body">
		<asp:Table id="table" CssClass="table table-striped" runat="server">
			<asp:TableHeaderRow id="tableHeader" TableSection="TableHeader" runat="server"/>
		</asp:Table>
	</div>
	<div class="panel-footer">
		<label class="btn btn-primary">
			<asp:CheckBox id="showCompleted" OnCheckedChanged="SendShowCompletedChanged" autocomplete="off" runat="server"/>
			Compleet
		</label>
		<label class="btn btn-primary">
			<asp:CheckBox id="showDeleted" OnCheckedChanged="SendShowDeletedChanged" autocomplete="off" runat="server"/>
			Verwijderd
		</label>
	</div>
</div>
