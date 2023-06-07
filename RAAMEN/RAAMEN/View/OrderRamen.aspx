<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="RAAMEN.View.OrderRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="RamenView" runat="server"></asp:GridView>
            <asp:Button ID="OrderBtn" runat="server" Text="Order" OnClick="OrderBtn_Click" />
        </div>
    </form>
</body>
</html>
