<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="PTCOrderSite.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
<h1>Error</h1>
<div class="formBox mediumForm">
    <p>The server has encountered an error. Please contact the Expert Help Desk at (916) 677-1032 and reference error:
    <% Response.Write(Request.QueryString["Error"]); %><br /><br />
    File/Process: '<% Response.Write(Request.QueryString["File"]); %>'</p>
</div>
</asp:Content>
