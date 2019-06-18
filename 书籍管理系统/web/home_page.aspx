<%@ Page Title="" Language="C#" MasterPageFile="MasterPage2.master" AutoEventWireup="true" CodeFile="home_page.aspx.cs" Inherits="web_Main" %>

<script runat="server">

   
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            style="margin-right: 1px" AllowPaging="True" Height="237px" 
        onpageindexchanged="GridView1_PageIndexChanged" 
        onpageindexchanging="GridView1_PageIndexChanging" 
        onrowcancelingedit="GridView1_RowCancelingEdit" 
        onrowdeleting="GridView1_RowDeleting" 
        onrowupdating="GridView1_RowUpdating" onrowediting="GridView1_RowEditing" 
        OnRowDataBound="GridView1_RowDataBound" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" CellPadding="10" ForeColor="#333333" GridLines="None" HorizontalAlign="Justify" PageSize="4" UseAccessibleHeader="False">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="isbn" HeaderText="ISBN" />
                <asp:BoundField DataField="BookName" HeaderText="书名" />
                <asp:BoundField DataField="bookAuthor" HeaderText="作者" />
                <asp:BoundField DataField="price" HeaderText="商品单价" />
                <asp:BoundField DataField="countIn" HeaderText="进货数量" />
                <asp:BoundField DataField="countOut" HeaderText="销售数量" />
                <asp:BoundField DataField="bookAbout" HeaderText="商品介绍" />
                <asp:TemplateField HeaderText="书籍种类">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("bookType") %>' 
                            ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                        <asp:DropDownList ID="ddlSort" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("bookType") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField HeaderText="操作" ShowDeleteButton="True" 
                    ShowEditButton="True" />
                
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
      
        </asp:Content>

