<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/MemberMasterPage.Master" AutoEventWireup="true" CodeBehind="ProfileMember.aspx.cs" Inherits="RAAMEN.View.Member.ProfileMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="NameLbl" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="NameTxb" runat="server"></asp:TextBox><br />

        <asp:Label ID="EmailLbl" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="EmailTxb" runat="server"></asp:TextBox><br />

        <asp:Label ID="GenderLbl" runat="server" Text="Gender"></asp:Label>
        <asp:RadioButton ID="RadioMale" runat="server" Text="Male" GroupName="Gender"/>
        <asp:RadioButton ID="RadioFemale" runat="server" Text="Female" GroupName="Gender"/><br />
            
        <asp:Label ID="PassLbl" runat="server" Text="New Password"></asp:Label>
        <asp:TextBox ID="PassTxb" runat="server" TextMode="Password"></asp:TextBox><br />

        <asp:Label ID="OldPassLbl" runat="server" Text="Confirm with Old Password"></asp:Label>
        <asp:TextBox ID="OldPassTxb" runat="server" TextMode="Password"></asp:TextBox><br />

        <asp:Label ID="status" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="UpdateBtn" runat="server" Text="Update Profile" OnClick="UpdateBtn_Click"/>
    </div>
</asp:Content>
