﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ColorOutputPage.aspx.cs" Inherits="Exam_1027.ColorOutputPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="  Submit  " OnClick="Button1_Click"/>
            <asp:Label ID="Label1" runat="server" Text="" ForeColor=""></asp:Label>


        </div>
    </form>
</body>
</html>
