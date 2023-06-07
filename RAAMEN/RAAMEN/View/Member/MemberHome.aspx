<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/MemberMasterPage.Master" AutoEventWireup="true" CodeBehind="MemberHome.aspx.cs" Inherits="RAAMEN.View.Member.MemberHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="NameLbl" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="RoleLbl" runat="server" Text="Role = Member"></asp:Label>
</asp:Content>