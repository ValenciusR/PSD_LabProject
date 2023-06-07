<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RAAMEN.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="NameLbl" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="NameTxb" runat="server"></asp:TextBox><br />

            <asp:Label ID="PassLbl" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="PassTxb" runat="server" TextMode="Password"></asp:TextBox><br />

            <asp:CheckBox ID="RememberMeCheckBox" runat="server" Text="Remember Me"/><br />

            <asp:Label ID="status" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
        </div>
    </form>
</body>
</html>
