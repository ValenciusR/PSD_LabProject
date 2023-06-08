<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionQueue.aspx.cs" Inherits="RAAMEN.View.TransactionQueue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="TransactionGV" runat="server" AutoGenerateEditButton="true" OnRowEditing="TransactionGV_RowEditing"></asp:GridView>
        </div>
    </form>
</body>
</html>
