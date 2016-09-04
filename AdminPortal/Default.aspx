<%@ Page Language="C#" Inherits="AdminPortal.Default" %>
<%@ Register Tagprefix="ak" TagName="FormListPanel" Src="FormListPanel.ascx" %>
<!DOCTYPE>
<html>
	<head>
		<title>Forms</title>
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
		<form runat="server">
			<ak:FormListPanel id="AutoAdvies" Heading="Auto-Advies" runat="server"/>
			<ak:FormListPanel id="AankoopBegeleiding" Heading="Aankoop-Begeleiding" runat="server"/>
			<ak:FormListPanel id="AankoopKeuring" Heading="Aankoop-Keuring" runat="server"/>
			<ak:FormListPanel id="GarantieKeuring" Heading="Garantie-Keuring" runat="server"/>
			<ak:FormListPanel id="ReparatieKeuring" Heading="Reparatie-Keuring" runat="server"/>
		</form>
		<script src="https://code.jquery.com/jquery-3.1.0.min.js"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"
			integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa"
			crossorigin="anonymous"></script>
	</body>
</html>
