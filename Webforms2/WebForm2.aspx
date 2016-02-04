<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Webforms2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style/stylesheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="searchBox" runat="server"></asp:TextBox>
            <asp:Button ID="runSearch" runat="server" Text="Run Query"/>
            <asp:Table ID="nameTable" runat="server">
            </asp:Table>
        </div>
    </form>
</body>
</html>