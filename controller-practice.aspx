<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="controller-practice.aspx.cs" Inherits="Exam_1027.controller_practice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <%-- LinkButton、HyperLink --%>
                <p>小工具</p>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"> 今天日期 </asp:LinkButton>
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                <br />
                <asp:LinkButton ID="LinkButton2" runat="server"  OnClick="LinkButton2_Click"> 今天星期幾 </asp:LinkButton>
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl="https://www.cwa.gov.tw/V8/C/W/County/index.html">看看今日天氣</asp:HyperLink>
            </div>
            <p>輸入名字</p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1"  runat="server" Text=" OK " OnClick="Button1_Click"/><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br /><br />           
                        
            <div>
                <%-- DropDownList --%>
                <p>選擇最喜歡的季節</p>
                
                <span>
                <asp:DropDownList  ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlImages_SelectedIndexChanged">
                    <asp:ListItem Text="選擇" Value="" />
                    <asp:ListItem Text="春" Value="春" />
                    <asp:ListItem Text="夏" Value="夏" />
                    <asp:ListItem Text="秋" Value="秋" />
                    <asp:ListItem Text="冬" Value="冬" />

                </asp:DropDownList>
                
                <%--<asp:Button ID="Button2" runat="server" Text="Submit" OnClick= "Button2_Click"/>--%>
                </span><br /><br />
                
                <asp:Image ID="Image1" runat="server"  Width="600"/>

            </div>
            <%--CheckBoxList  --%>            
            <p>選擇感興趣的主題(可複選):</p>
            <asp:CheckBoxList ID="cblOptions" runat="server">
                <asp:ListItem Text="自然景觀" Value="1" />
                <asp:ListItem Text="人文古蹟" Value="2" />
                <asp:ListItem Text="美食餐廳" Value="3" />
                           
            </asp:CheckBoxList>


            <%-- RadioButtonList --%>
            <p>年齡: </p>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" >                
                <asp:ListItem Text="20 ~ 40歲" Value="20 ~ 40歲" />
                <asp:ListItem Text="41 ~ 65歲" Value="41 ~ 65歲" />
                <asp:ListItem Text="65歲以上" Value="65歲以上" />
            </asp:RadioButtonList>

            <%-- RadioButton --%>
            <div>
            <p>食物選擇(主食、料理風格 各擇一)</p>
            <asp:RadioButton ID="rbOption1" runat="server" Text="飯" GroupName="Group1" />
            <asp:RadioButton ID="rbOption2" runat="server" Text="麵" GroupName="Group1" />
            <asp:RadioButton ID="rbOption3" runat="server" Text="台式料理" GroupName="Group2" />
            <asp:RadioButton ID="rbOption4" runat="server" Text="西式料理" GroupName="Group2" />
            <asp:RadioButton ID="rbOption5" runat="server" Text="日式料理" GroupName="Group2" />
            
            </div>
            <br />

            <%-- CheckBox、ImageButton --%>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="願意收到廣告訊息"/><br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="https://cdn-icons-png.flaticon.com/512/5651/5651414.png" Width="100" OnClick="ImageButton1_Click"/><br />
            
            
            <%--<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>--%>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>


        </div>
    </form>
</body>
</html>
