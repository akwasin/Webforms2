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
            <asp:Label ID="RunQueryLabel" runat="server">Press 'Run Query' to view all categories</asp:Label>
            <asp:Button ID="runSearch" runat="server" Text="Run Query" OnClick="runSearch_Click" />
        </div>

        <div>
            <asp:TextBox ID="InsertCategoryTextBox" runat="server"></asp:TextBox>
            <asp:Label ID="CategoryLabelBox" runat="server"></asp:Label>
            <asp:Button ID="addButton" runat="server" Text="Add Category" OnClick="InsertCategory_Click" />
        </div>

        <asp:Table ID="QueryTable" runat="server">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Table ID="CategoryTable" runat="server">
                    </asp:Table>
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:DropDownList ID="CategoryDropDown" runat="server">
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    
    </form>
</body>
</html>
