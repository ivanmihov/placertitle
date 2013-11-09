<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PTCOrderSite.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

<div class="formBox loginBox">
    <asp:Table runat="server" ID="tblLogin">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                <asp:Label runat="server" ID="lblLogin" Text="Username:"></asp:Label>
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:TextBox runat="server" ID="txtLogin"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="TableRow1" runat="server">
            <asp:TableCell ID="TableCell1" runat="server">
                <asp:Label runat="server" ID="lblPassword" Text="Password:"></asp:Label>
            </asp:TableCell>
            <asp:TableCell ID="TableCell2" runat="server">
                <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" ColumnSpan=2>
                <asp:Button runat="server" ID="cmdSubmit" Text="Login" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>

</asp:Content>
