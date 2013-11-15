<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="PTCOrderSite.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
<h1>Welcome <% Response.Write(Session["username"]); %></h1>

<div class="mediumForm formBox">
    <h3>Operations</h3>
    <ul>
        <li><asp:HyperLink runat="server" Text="Open an Order" NavigateUrl="~/EnterAddress.aspx"></asp:HyperLink></li>
        <li><asp:HyperLink runat="server" Text="Log Out" NavigateUrl="~/Login.aspx"></asp:HyperLink></li>
    </ul>
</div>
</asp:Content>
