<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/LoginCss.css" type="text/css" />
    
</head>
<body><center>
    <form id="form1" runat="server" style="border-style: dashed; margin-top:100px;" >
    <div>
    
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="用户注册"></asp:Label><br /><br />
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="*  用户名"></asp:Label>
    <asp:TextBox ID="txtUsername" runat="server" Height="25px" Width="223px"></asp:TextBox>
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtUsername" ErrorMessage="请输入用户名" 
        Display="Dynamic"></asp:RequiredFieldValidator>
    
    <p>
    <asp:Label ID="Label3" runat="server" Text="*  密码"></asp:Label>&nbsp;
    <asp:TextBox ID="txtPwd" runat="server" Height="25px" Width="223px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtPwd" ErrorMessage="请输入密码" Display="Dynamic"></asp:RequiredFieldValidator>
    </p>
    <asp:Label ID="Label4" runat="server" Text="*确认密码"></asp:Label>
    <asp:TextBox ID="txtPwdTwice" runat="server" Height="25px" Width="223px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtPwdTwice" ErrorMessage="请确认密码" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txtPwd" ControlToValidate="txtPwdTwice" Display="Dynamic" 
            ErrorMessage="密码不一致"></asp:CompareValidator>
    <br /><br />
        <asp:Label runat="server" Text="邮箱              " ID="Label12"></asp:Label>&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server" Height="22px" Width="209px"></asp:TextBox>
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="txtEmail" ErrorMessage="请输入邮箱" Display="Dynamic"></asp:RequiredFieldValidator>
    
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtEmail" ErrorMessage="请填写正确的邮箱格式" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
        Display="Dynamic"></asp:RegularExpressionValidator>
    <br /><br />
    <asp:Button ID="btnOk" runat="server" Text=" 注册" Height="58px" Width="158px" 
        onclick="btnOk_Click"/>&nbsp;&nbsp;<asp:Label ID="lblMsg" runat="server"></asp:Label>
    &nbsp;&nbsp;
    <asp:Button ID="btnRe" runat="server" Text="重填" Height="58px" Width="158px" />
    </form>
    </center>
</body>
</html>
