<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/MemberMasterPage.Master" AutoEventWireup="true" CodeBehind="HistoryMember.aspx.cs" Inherits="RAAMEN.View.Member.HistoryMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="CustomerHistory" runat="server" AutoGenerateSelectButton="true" OnRowEditing="CustomerHistory_RowEditing"></asp:GridView>
    </div>
</asp:Content>
