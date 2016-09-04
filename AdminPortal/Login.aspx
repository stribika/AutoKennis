<%@ Page Language="C#" Inherits="AdminPortal.Login" %>
<!DOCTYPE html>
<html>
	<head>
		<title>Auto-Kennis inloggen</title>
		<link rel="stylesheet" 
			href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"
			integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u"
			crossorigin="anonymous"/>
		<link rel="stylesheet"
			href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css"
			integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp"
			crossorigin="anonymous"/>
		<link rel="stylesheet" href="css/adminportal.css"/>
	</head>
	<body>
		<form id="LoginForm" runat="server">
			<asp:Panel id="ErrorMessage" Visible="false" CssClass="alert alert-danger" role="alert" runat="server">
				Gebruikersnaam of wachtwoord incorrect.
			</asp:Panel>
			<br/>
			<label for="Username">Gebruikersnaam</label>
			<div class="input-group">
				<span class="input-group-addon">
					<span class="glyphicon glyphicon-user" aria-hidden="true"></span>
				</span>
				<asp:TextBox id="Username" TextMode="SingleLine" placeholder="Gebruikersnaam" CssClass="form-control" runat="server"/>
			</div>
			<br/>
			<label for="Password">Wachtwoord</label>
			<div class="input-group">
				<span class="input-group-addon">
					<span class="glyphicon glyphicon-lock" aria-hidden="true"></span>
				</span>
				<asp:TextBox id="Password" TextMode="Password" placeholder="Wachtwoord" CssClass="form-control" runat="server"/>
			</div>
			<br/>
			<asp:Button id="SubmitButton" Text="Inloggen" OnClick="SubmitButtonClicked" CssClass="btn btn-default" runat="server"/>
		</form>
		<script src="https://code.jquery.com/jquery-3.1.0.min.js"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"
			integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa"
			crossorigin="anonymous"></script>
	</body>
</html>
