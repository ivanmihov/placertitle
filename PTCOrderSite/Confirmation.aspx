<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="PTCOrderSite.confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
<h1>Thank you for your order.</h1>
Thank you, your order <span>Confirmaiton number</span> has been submitted. Please print or return to home.
<div class="mediumForm formBox">
    <h3>Operations</h3>
    <ul>
        <!--Need to put in the java to print-->
        <li><asp:HyperLink ID="HyperLink1" runat="server" Text="Print Confirmation" NavigateUrl="#"></asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink2" runat="server" Text="Log Out" NavigateUrl="~/Login.aspx"></asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink3" runat="server" Text="Home" NavigateUrl="~/MainMenu.aspx"></asp:HyperLink></li>
    
    </ul>
</div>
</asp:Content>
