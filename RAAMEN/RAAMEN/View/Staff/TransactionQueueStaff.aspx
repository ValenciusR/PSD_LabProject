<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/StaffMasterPage.Master" AutoEventWireup="true" CodeBehind="TransactionQueueStaff.aspx.cs" Inherits="RAAMEN.View.Staff.TransactionQueueStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="TransactionGV" runat="server" AutoGenerateEditButton="true" OnRowEditing="TransactionGV_RowEditing"></asp:GridView>
    </div>
</asp:Content>
