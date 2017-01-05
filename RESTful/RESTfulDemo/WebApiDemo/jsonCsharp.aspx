<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jsonCsharp.aspx.cs" Inherits="WebApiDemo.jsonCsharp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Get persons" OnClick="Button1_Click" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <br /><asp:button ID="Button2" runat="server" Text="Add new person" OnClick="Button2_Click" /><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </div><br />
    </form>
</body>
</html>
