<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="PTCOrderSite.confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
<h1>Thank you for your order.</h1>

<div class="mediumForm formBox">
    <h3>Operations</h3>
    <ul>
        <li><asp:HyperLink ID="HyperLink1" runat="server" Text="Home" NavigateUrl="~/MainMenu.aspx"></asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink2" runat="server" Text="Log Out" NavigateUrl="~/Login.aspx"></asp:HyperLink></li>
    </ul>
</div>
</asp:Content>
