<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="TransactionQueueAdmin.aspx.cs" Inherits="RAAMEN.View.Admin.TransactionQueueAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="TransactionGV" runat="server" AutoGenerateEditButton="true" OnRowEditing="TransactionGV_RowEditing"></asp:GridView>
    </div>
</asp:Content>
