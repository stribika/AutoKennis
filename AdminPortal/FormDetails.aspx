﻿<%@ Page Language="C#" Inherits="AdminPortal.FormDetails" %>
<!DOCTYPE>
<html>
	<head>
		<title>Form details</title>
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
		<form id="form" runat="server">
			<asp:Button id="GenerateReportButton" Text="Rapport maken" CssClass="btn btn-default" runat="server"/>
			<asp:Button id="CompleteButton" Text="Compleet" CssClass="btn btn-default" runat="server"/>
			<asp:Button id="DeleteButton" Text="Verwijderen" CssClass="btn btn-default" runat="server"/>
			<asp:Button id="PayButton" Text="Betaald" CssClass="btn btn-default" runat="server"/>
			<br/>
		</form>
		<script src="https://code.jquery.com/jquery-3.1.0.min.js"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"
			integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa"
			crossorigin="anonymous"></script>
	</body>
</html>
