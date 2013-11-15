<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PTCOrderSite.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

<h1>Please Login</h1>

<div class="formBox narrowForm loginFormBox">
    <div><asp:TextBox runat="server" ID="txtUsername" placeholder="Username" CssClass="loginTextbox"></asp:TextBox></div>
    <br />
    <div><asp:TextBox runat="server" ID="txtPassword" placeholder="Password" CssClass="loginTextbox" TextMode="Password"></asp:TextBox></div>
    <div class="formSubmit">
        <asp:CheckBox runat="server" ID="rememberLogin" />
        <span class="rememberUser">Remember Username</span>
        <asp:Button runat="server" ID="cmdSubmit" Text="Login" 
            onclick="cmdSubmit_Click" /></div>
    <div class="forgotCredentials">Forgot Username or Password?</div>
    <div class="requestId">Request Username</div>
</div>

</asp:Content>
