<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/MemberMasterPage.Master" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="RAAMEN.View.Member.OrderRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="RamenView" runat="server"></asp:GridView>
        <asp:Button ID="OrderBtn" runat="server" Text="Order" OnClick="OrderBtn_Click" />
    </div>
</asp:Content>
