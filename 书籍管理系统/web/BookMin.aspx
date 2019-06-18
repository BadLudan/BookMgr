<%@ Page Title="" Language="C#" MasterPageFile="MasterPage2.master" AutoEventWireup="true" CodeFile="BookMin.aspx.cs" Inherits="BookMin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
        <table style="width: 50%; margin-left:40px;" border="0px" cellpadding="20px" cellspacing="0px">
            <tr bgcolor="#bbb">
                <td width="200px">
                    图书名称
                </td>
                <td>
                    <%# Eval("BookName")%>
                </td>
            </tr>
            <tr bgcolor="#fff">
                <td>
                    图书价格
                </td>
                <td>
                    <%# Eval("Price")%>
                </td>
            </tr>
            <tr bgcolor=#bbb>
                <td>
                    图书图片
                </td>
                <td>
                    <%--<img alt="" src='<%# Eval("image")%>' />--%>
                    <asp:Image ID="Image1" Height="200" runat="server" ImageUrl='<%# Eval("image")%>' />
                </td>
            </tr>
            <tr bgcolor=#fff>
                <td>
                    图书介绍
                </td>
                <td>
                    <%# Eval("BookAbout")%>
                </td>
            </tr>
        </table>
    
    </ItemTemplate>

    <SeparatorTemplate>
    <hr />
    </SeparatorTemplate>
    </asp:Repeater>
</asp:Content>

