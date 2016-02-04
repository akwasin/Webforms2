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
            <asp:DropDownList ID="searchList" runat="server">
                <asp:ListItem Value="">(Select Searchstring)</asp:ListItem>
                <asp:ListItem>FirstName</asp:ListItem>
                <asp:ListItem>LastName</asp:ListItem>
                <asp:ListItem>MiddleName</asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="runSearch" runat="server" Text="Run Query" OnClick="runSearch_Click" />
            
            <asp:TextBox ID="addBoxFirstName" runat="server"></asp:TextBox>
            <asp:TextBox ID="addBoxLastName" runat="server"></asp:TextBox>
            
            <asp:Button ID="addButton" runat="server" Text="Add Person" OnClick="addPerson_Click" />
            
            <asp:Table ID="nameTable" runat="server">
            </asp:Table>
        </div>
    </form>
</body>
</html>
