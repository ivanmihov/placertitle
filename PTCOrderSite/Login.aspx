<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PTCOrderSite.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

<h1>Please Login</h1>

<div class="formBox narrowForm">
    <div class="loginPane">
        <div class="loginLabel">Username</div>
        <div class="loginInput"><asp:TextBox runat="server" ID="txtUsername"></asp:TextBox></div>
        <div class="loginLabel">Password</div>
        <div class="loginInput"><asp:TextBox runat="server" ID="txtPassword"></asp:TextBox></div>
        <div class="loginButton"><asp:Button runat="server" ID="cmdSubmit" Text="Login" 
                onclick="cmdSubmit_Click" /></div>
    </div>
</div>

</asp:Content>
