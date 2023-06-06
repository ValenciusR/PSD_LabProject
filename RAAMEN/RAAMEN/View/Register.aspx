<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RAAMEN.View.Register" %>

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

            <asp:Label ID="EmailLbl" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="EmailTxb" runat="server"></asp:TextBox><br />

            <asp:Label ID="GenderLbl" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButton ID="RadioMale" runat="server" Text="Male" GroupName="Gender"/>
            <asp:RadioButton ID="RadioFemale" runat="server" Text="Female" GroupName="Gender"/><br />
            
            <asp:Label ID="PassLbl" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="PassTxb" runat="server" TextMode="Password"></asp:TextBox><br />

            <asp:Label ID="ConfirmLbl" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="ConfirmTxb" runat="server" TextMode="Password"></asp:TextBox><br />

            <asp:Label ID="status" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click"/>
        </div>
    </form>
</body>
</html>
