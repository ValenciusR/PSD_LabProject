﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="ManageRamenAdmin.aspx.cs" Inherits="RAAMEN.View.Admin.ManageRamenAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="ramenGV" AutoGenerateEditButton="true" AutoGenerateDeleteButton="true" OnRowEditing="ramenGV_RowEditing" OnRowDeleting="ramenGV_RowDeleting" runat="server"></asp:GridView>
    </div>
    <div>
        <asp:Button ID="AddBtn" runat="server" Text="Add New Ramen" OnClick="AddBtn_Click" />
    </div>
</asp:Content>