<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="Viewbook.aspx.cs" Inherits="anchalproject.Viewbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Book name"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="refresh"   />
    </p>
    <p>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="bid" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="bid" HeaderText="bid" InsertVisible="False" ReadOnly="True" SortExpression="bid" />
                <asp:BoundField DataField="bname" HeaderText="bname" SortExpression="bname" />
                <asp:BoundField DataField="bauthor" HeaderText="bauthor" SortExpression="bauthor" />
                <asp:BoundField DataField="bprice" HeaderText="bprice" SortExpression="bprice" />
                <asp:BoundField DataField="bquan" HeaderText="bquan" SortExpression="bquan" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentConnectionString %>" SelectCommand="SELECT * FROM [NewBook1]"></asp:SqlDataSource>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
