<%@ Control Language="C#" Inherits="AdminPortal.FormListPanel" %>
<div class="panel panel-default">
	<div class="panel-heading"><%= Heading %></div>
	<div class="panel-body">
		<asp:Table id="table" CssClass="table" runat="server"/>
	</div>
	<div class="panel-footer">
		<label class="btn btn-primary">
			<asp:CheckBox id="showCompleted" OnCheckedChanged="SendShowCompletedChanged" autocomplete="off" runat="server"/>
			Voltooid
		</label>
		<label class="btn btn-primary">
			<asp:CheckBox id="showDeleted" OnCheckedChanged="SendShowDeletedChanged" autocomplete="off" runat="server"/>
			Verwijderd
		</label>
	</div>
</div>
