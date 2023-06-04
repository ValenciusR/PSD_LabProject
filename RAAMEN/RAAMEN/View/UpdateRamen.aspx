<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateRamen.aspx.cs" Inherits="RAAMEN.View.UpdateRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Name" runat="server" Text="Name : "></asp:Label>
            <asp:TextBox ID="NameTb" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Meat" runat="server" Text="Meat : "></asp:Label>
            <asp:DropDownList ID="meatIdDDl" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [Name] FROM [Meat]" ></asp:SqlDataSource>
            <br />

            <asp:Label ID="Broth" runat="server" Text="Broth : "></asp:Label>
            <asp:TextBox ID="BrothTb" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Price" runat="server" Text="Price  : "></asp:Label>
            <asp:TextBox ID="PriceTb" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click1" />
        </div>
    </form>
</body>
</html>
