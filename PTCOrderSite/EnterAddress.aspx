<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="EnterAddress.aspx.cs" Inherits="PTCOrderSite.EnterAddress" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h1>Please Enter an Address</h1>
    <div class="formBox mediumForm">
        <div class="formElement">
            <asp:TextBox runat="server" ID="txtAddress" CssClass="formTextbox" placeholder="Address"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox runat="server" ID="txtZip" CssClass="zip formTextbox" placeholder="Zip Code"></asp:TextBox>
        </div>
        <br />
        <div class="formElement formSubmit">
            <asp:ImageButton src="images/submit-btn.png" runat="server" Text="Submit" AlternateText="Button" PostBackUrl="~/ValidateAddress.aspx" />
        </div>
        <br />
    </div>
</asp:Content>
