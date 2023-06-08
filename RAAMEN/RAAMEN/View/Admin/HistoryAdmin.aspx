<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="HistoryAdmin.aspx.cs" Inherits="RAAMEN.View.Admin.HistoryAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="AdminHistory" runat="server"></asp:GridView>
    </div>
</asp:Content>
