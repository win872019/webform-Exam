<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login-practice.aspx.cs" Inherits="Exam_1027.Login_practice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            使用者名稱:
            <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox><br />
            密碼:
            <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox><br />
            <asp:Button ID="LoginButton" runat="server" Text="登入" OnClick="LoginButton_Click" /><br />
            <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label><br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/welcome-practice.aspx">帳戶頁面</asp:HyperLink>
    </form>
</body>
</html>
