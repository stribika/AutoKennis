<%@ Page Language="C#" Inherits="AdminPortal.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
	<link rel="stylesheet" type="text/css" href="css/adminportal.css"/>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Table id="GarantieKeuringTable" runat="server">
		</asp:Table>
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
	</form>
</body>
</html>
