<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="countingViewState.aspx.cs" Inherits="Exam_1027.countingViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br/>

            <asp:Button ID="Button1" runat="server" Text="  +1  " OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
