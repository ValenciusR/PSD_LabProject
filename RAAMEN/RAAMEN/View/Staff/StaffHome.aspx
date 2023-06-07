<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/StaffMasterPage.Master" AutoEventWireup="true" CodeBehind="StaffHome.aspx.cs" Inherits="RAAMEN.View.Staff.StaffHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="NameLbl" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="RoleLbl" runat="server" Text="Role = Member"></asp:Label>
    <asp:GridView ID="MemberView" runat="server"></asp:GridView>
</asp:Content>
