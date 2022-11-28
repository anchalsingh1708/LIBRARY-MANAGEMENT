<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="IssueReturn.aspx.cs" Inherits="anchalproject.IssueReturn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Student Enrollement No" ToolTip="  "></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtenroll" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Book Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Book Issue Date"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" Text="Book Return date"></asp:Label>
    </p>
    <p>
        <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="ISSUE BOOK" OnClick="Button1_Click" BackColor="#660033" Font-Bold="True" ForeColor="White" Height="36px" Width="148px" />
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
    <p>
    </p>
    <p>
    </p>
</asp:Content>
