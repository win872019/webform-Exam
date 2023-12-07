<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Exam_1027.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="StatusLabel" runat="server" Text="Label"></asp:Label><br/>
            <asp:Button ID="LogoutButton" runat="server" Text="登出" OnClick="LogoutButton_Click"/>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">登入頁面</asp:HyperLink>
        </div>
    </form>
</body>
</html>
