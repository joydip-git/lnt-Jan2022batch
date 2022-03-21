<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PageBasedApplication.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Value:&nbsp;<asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Show Value" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
