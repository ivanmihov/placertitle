<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PTCOrderSite.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

<h1>Please Login</h1>
<div id="loginContainer">
    <div class="loginFormBox">
    <div style="text-align:center; margin-top:20px"><asp:TextBox runat="server" ID="txtUsername" placeholder="Username" CssClass="loginTextbox"></asp:TextBox></div>
    <br />
    <div style="text-align:center"><asp:TextBox runat="server" ID="txtPassword" placeholder="Password" CssClass="loginTextbox" TextMode="Password"></asp:TextBox></div>
    <div class="rememberUser"><asp:CheckBox runat="server" ID="rememberLogin" Text="Remember Username"/></div>
    <div class="loginButton">
        <asp:ImageButton src="images/login-btn.png" runat="server" Text="Login" AlternateText="Button" onclick="cmdSubmit_Click"/>
    </div>
    <div class="forgotCredentials">Forgot Username or Password?</div>
    <div class="requestId">Request Username</div>
</div>
    <div class="loginInfo"><br />
        <p style="text-align:center; color:#047fa2;"><strong>Need an account?</strong></p>
        <p>    
            Placer Title Company web access accounts are issued by our Database 
            Administrators. You may request a login by clicking on Request Login ID.
        </p>
        <p>Forgot your Login ID or password? Click here.</p>
        <p style="text-align:center; color:#047fa2;"><strong>Bookmarking</strong></p>
        <p>
            Please only bookmark this page as bookmarking other pages 
            could cause errors. To bookmark this page, depending on your browser, 
            click Favorites or Bookmarks from your browser menu and select Add to 
            Favorites or Bookmark this page.
        </p>

</div>
</div>
</asp:Content>
