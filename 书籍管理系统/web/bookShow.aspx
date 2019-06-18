<%@ Page Title="" Language="C#" MasterPageFile="MasterPage2.master" AutoEventWireup="true" CodeFile="bookShow.aspx.cs" Inherits="bookShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="dlstShowBook" runat="server" BackColor="LightGoldenrodYellow" 
        BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
        RepeatColumns="4" RepeatDirection="Horizontal" Width="1200px" 
        onselectedindexchanged="dlstShowBook_SelectedIndexChanged" 
        onitemcommand="dlstShowBook_ItemCommand">
        <AlternatingItemStyle BackColor="PaleGoldenrod" />
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <ItemTemplate>
            <table style="width:100%;">
                <tr>
                    <td rowspan="4" style="width: 60px">
                        <asp:Image Height="120px" ID="Image2" runat="server" ImageUrl='<%# bind("image") %>' />
                    </td>
                    <td style="height: 22px">
                        名称：<asp:Label ID="Label1" runat="server" Text='<%# bind("BookName") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        销售数量：<asp:Label ID="Label2" runat="server" Text='<%# bind("CountOut") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        单价：<asp:Label ID="Label3" runat="server" Text='<%# bind("Price") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="height: 22px">
                        <asp:LinkButton ID="LinkButton1" runat="server" 
                            CommandArgument='<%# bind("BookName") %>' CommandName="describe">详细信息</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">&nbsp;&nbsp;&nbsp;购买</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
    </asp:DataList>
</asp:Content>

