<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="anchalproject.home" StylesheetTheme="morebook"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> 
        <asp:Image ID="Image1" runat="server" Imageurl="~/Controllers/lib.png" Width="500px"/>
    </h1>
    <p> 
        &nbsp;</p>
    <p> 
        <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1" />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/add.xml"></asp:XmlDataSource>
    </p>
    <p> 
        <asp:Button ID="Button1" runat="server" BackColor="#660033" Font-Bold="True" ForeColor="White" OnClick="Button1_Click" Text="EXPLORE MORE BOOKS" />
    </p>
    <p> &nbsp;</p>
    
</asp:Content>
    