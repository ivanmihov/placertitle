<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="ValidateAddress.aspx.cs" Inherits="PTCOrderSite.ValidateAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

<h1>Validate Address</h1>

<div class="formBox mediumForm">

    <asp:Table runat="server" ID="tblSearchResults"></asp:Table>
    <div class="formElement formSubmit"><asp:Button runat="server" Text="Continue" 
            ID="cmdContinue" PostBackUrl="~/Order.aspx" /></div>

</div>

</asp:Content>
