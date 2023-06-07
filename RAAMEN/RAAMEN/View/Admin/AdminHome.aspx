<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="RAAMEN.View.Admin.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="NameLbl" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="RoleLbl" runat="server" Text="Role = Admin"></asp:Label>

    <asp:GridView ID="StaffView" runat="server"></asp:GridView>
</asp:Content>
