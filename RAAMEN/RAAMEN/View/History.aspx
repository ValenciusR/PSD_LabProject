<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="RAAMEN.View.History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="CustomerHistory" runat="server"></asp:GridView>
            <asp:GridView ID="AdminHistory" runat="server"></asp:GridView>
        
        </div>
    </form>
</body>
</html>
