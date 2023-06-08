﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="InsertRamenAdmin.aspx.cs" Inherits="RAAMEN.View.Admin.InsertRamenAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Name" runat="server" Text="Name : "></asp:Label>
    <asp:TextBox ID="NameTb" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Meat" runat="server" Text="Meat : "></asp:Label>
    <asp:DropDownList ID="MeatDdl" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id" OnSelectedIndexChanged="MeatDdl_SelectedIndexChanged"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Name], [Id] FROM [Meat]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="Broth" runat="server" Text="Broth : "></asp:Label>
    <asp:TextBox ID="BrothTb" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Price" runat="server" Text="Price : "></asp:Label>
    <asp:TextBox ID="PriceTb" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="StatusLbl" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
</asp:Content>
