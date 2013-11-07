<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PTCOrderSite.frmLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link type="text/css" href="styles.css" rel="Stylesheet" />
</head>
<body>
    <form id="frmLogin" runat="server">
    <div class="header">
        <img class="logo" src="images/logo.png" />
    </div>

    <div class="main">

    <p>This is a sample C# web application</p>

    <p>Click the buttons below and see what happens</p>

    <asp:TextBox runat="server" ID="txtTest">This is some sample text</asp:TextBox>
    <br />
    <asp:Button runat="server" ID="btnShowHide" Text="Show/Hide" 
            onclick="btnShowHide_Click" />
    <br />
    <asp:Button runat="server" ID="btnChangeColor" Text="Change Color" 
            onclick="btnChangeColor_Click" />

    </div>

    </form>
</body>
</html>
