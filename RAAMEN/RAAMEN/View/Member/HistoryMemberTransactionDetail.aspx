<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/MemberMasterPage.Master" AutoEventWireup="true" CodeBehind="HistoryMemberTransactionDetail.aspx.cs" Inherits="RAAMEN.View.Member.HistoryMemberTransactionDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <asp:GridView ID="detailTransaction" runat="server"></asp:GridView>

    </div>
</asp:Content>
