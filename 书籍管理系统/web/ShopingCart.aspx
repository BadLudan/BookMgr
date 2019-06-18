<%@ Page Title="" Language="C#" MasterPageFile="MasterPage2.master" AutoEventWireup="true" CodeFile="ShopingCart.aspx.cs" Inherits="ShopingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            style="margin-right: 1px" AllowPaging="True" Height="100px" 
        onpageindexchanged="GridView1_PageIndexChanged" 
        onpageindexchanging="GridView1_PageIndexChanging" 
        onrowcancelingedit="GridView1_RowCancelingEdit" 
        onrowdeleting="GridView1_RowDeleting" 
        onrowupdating="GridView1_RowUpdating" onrowediting="GridView1_RowEditing" 
        OnRowDataBound="GridView1_RowDataBound" 
         Width="892px" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="6">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="cb1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="id" HeaderText="订单号" />
                <asp:TemplateField HeaderText="Image">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image2" runat="server" Height="100px" ImageAlign="Middle"  ImageUrl='<%# bind("image") %>'
                            Width="59px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="isbn" HeaderText="ISBN" />
                <asp:BoundField DataField="BookName" HeaderText="书名" />
                <asp:BoundField DataField="bookAuthor" HeaderText="作者" />
                <asp:BoundField DataField="price" HeaderText="商品单价" />
                <asp:BoundField DataField="countIn" HeaderText="进货数量" />
                <asp:BoundField DataField="countOut" HeaderText="销售数量" />
                <asp:BoundField DataField="bookAbout" HeaderText="商品介绍" />
                <asp:TemplateField HeaderText="书籍种类">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("bookType") %>' ></asp:TextBox>
                        <asp:DropDownList ID="ddlSort" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("bookType") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField HeaderText="操作" ShowDeleteButton="True" 
                    ShowEditButton="True" EditText="" />
                <asp:TemplateField HeaderText="数量">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" value ="1"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" value ="2" Height="22px" Width="20px"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerSettings Mode="NextPreviousFirstLast" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="下订单" Height="30px" 
        Width="90px" onclick="Button1_Click" />
</asp:Content>

