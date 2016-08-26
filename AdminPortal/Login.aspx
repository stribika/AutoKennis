<%@ Page Language="C#" Inherits="AdminPortal.Login" %>
<!DOCTYPE html>
<html>
	<head>
		<title>Auto-Kennis inloggen</title>
		<link rel="stylesheet" type="text/css" href="css/adminportal.css"/>
	</head>
	<body>
		<form id="LoginForm" runat="server">
			<label for="Username">Gebruikersnaam</label>
			<asp:TextBox id="Username" TextMode="SingleLine" runat="server"/><br/>
			<label for="Password">Wachtwoord</label>
			<asp:TextBox id="Password" TextMode="Password" runat="server"/><br/>
			<asp:Label id="ErrorMessage" Visible="false" runat="server"/><br/>
			<asp:Button id="SubmitButton" Text="Inloggen" OnClick="SubmitButtonClicked" runat="server"/>
		</form>
	</body>
</html>
