<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="PTCOrderSite.confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
<h1>Thank you for your order.</h1>
Thank you, your order number is [order number]. Please print or return to home.
<div class="mediumForm formBox">
    <h3>Operations</h3>
    <ul>
        <!--Need to put in the java to print-->
        <li><a href="javascript:window.print()">Print Confirmation</a></li>
        <li><asp:LinkButton ID="lnkLogOut" runat="server" onclick="lnkLogOut_Click">Log Out</asp:LinkButton></li>
        <li><a href="MainMenu.aspx">Home</a></li>
    
    </ul>
</div>
</asp:Content>
