<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropDownList.aspx.cs" Inherits="Exam_1027.dropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Text="選擇" Value="" />

                    <asp:ListItem Text="Green" Value="Green" />

                    <asp:ListItem Text="Red" Value="Red" />
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
