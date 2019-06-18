<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/LoginCss.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id = "greet" align="center" style="border-style: dashed; height: 636px; left: 20%; position: fixed;">
       <p> &nbsp;</p>
        <p> &nbsp;</p>
        <p > <h1>会员登录</h1></p>
        <p> &nbsp;</p>
        <p> <asp:Label ID="Label1" runat="server" Text="账号：" Font-Size="X-Large" 
               Font-Names="微软雅黑"></asp:Label>
        <asp:TextBox ID="username" runat="server" Height="29px" Width="180px" 
               Font-Names="微软雅黑" Font-Size="X-Large"></asp:TextBox>
        </p>
        <br />
        <br />
       <p> <asp:Label ID="Label2" runat="server" Text="密码：" Font-Size="X-Large" 
               Font-Names="微软雅黑"></asp:Label>
        <asp:TextBox ID="password" runat="server" Height="34px" Width="183px" 
               Font-Names="微软雅黑" Font-Size="X-Large" TextMode="Password"></asp:TextBox>
        </p>
        <br />
        <asp:ImageButton ID="loginBtn" runat="server" ImageUrl="~/image/login.jpg"
            onclick="ImageButton1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="registerBtn" runat="server" ImageUrl="~/image/zhuce.jpg"
            onclick="registerBtn_Click" />
        <br />
    </div>
    </form>
</body>
</html>
