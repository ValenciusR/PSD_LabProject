<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="ViewReport.aspx.cs" Inherits="RAAMEN.View.Admin.ViewReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <CR:CrystalReportViewer ID="CrystalReportViewer" runat="server" AutoDataBind="true" />
    </div>
</asp:Content>
