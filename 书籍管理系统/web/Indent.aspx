<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="MasterPage2.master" CodeFile="Indent.aspx.cs" Inherits="Indent_aspx" %>

<script runat="server">

   
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
   
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        onrowdeleting="GridView1_RowDeleting"
            style="margin-right: 1px" AllowPaging="True" Height="125px" 
       
         Width="892px" CellPadding="6" ForeColor="#333333" GridLines="None" PageSize="6" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="订单号" />
                <asp:BoundField DataField="isbn" HeaderText="ISBN" />
                <asp:BoundField DataField="BookName" HeaderText="书名" />
                <asp:BoundField DataField="price" HeaderText="商品单价" />
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
                <asp:BoundField DataField="Number" HeaderText="数量" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerSettings Mode="NextPreviousFirstLast" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
            
        <asp:Label ID="Label1" runat="server" BorderStyle="Solid" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" Height="0px" Width="200px"></asp:Label>
</asp:Content>
