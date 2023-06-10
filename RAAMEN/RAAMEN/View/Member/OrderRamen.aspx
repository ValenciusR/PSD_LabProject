<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/MemberMasterPage.Master" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="RAAMEN.View.Member.OrderRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="RamenView" runat="server"></asp:GridView>
        <br />

        <asp:GridView ID="RamensOrder" runat="server"></asp:GridView>
        <br />
        <asp:Label ID="ValidationOrder" runat="server" Text=""></asp:Label>
        <br />

        <asp:Label ID="ramenLbl" runat="server" Text="Ramen ID"></asp:Label>
        <br />
        <asp:TextBox ID="ramenId" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="QuantityLbl" runat="server" Text="Quantity"></asp:Label>
        <br />
        <asp:TextBox ID="ramenQty" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Validation" runat="server" Text=""></asp:Label>
        <br />

        <asp:Button ID="AddBtn" runat="server" Text="Add To Cart" OnClick="AddBtn_Click" />
        <br />
        <br />
        <asp:Button ID="ClearCart" runat="server" Text="Clear Cart" OnClick="ClearCart_Click"/>
        <br />
        <br />
        <asp:Button ID="OrderBtn" runat="server" Text="Order" OnClick="OrderBtn_Click" />
    </div>
</asp:Content>
