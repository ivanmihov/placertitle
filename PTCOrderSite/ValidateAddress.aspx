<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="ValidateAddress.aspx.cs" Inherits="PTCOrderSite.ValidateAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" type="text/javascript">
    function changeSelection() {
        var radioButtons = document.getElementsByTagName("ctl00$body$AddressSelection");

        alert("about to enter loop");

        alert("radioButtons.length=" + radioButtons.length);

        for (var i = 0; i < radioButtons.length; i++) {
            alert("in loop, i=" + i);
            if (radioButtons[i].checked == true)
                alert(radioButtons[i] + "is checked");
        }
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

<h1>Validate Address</h1>

<div class="formBox mediumForm">
    <asp:HiddenField runat="server" ID="selectedAddress" />
    <asp:HiddenField runat="server" ID="selectedCity" />
    <asp:HiddenField runat="server" ID="selectedState" />
    <asp:HiddenField runat="server" ID="selectedZip" />
    <asp:HiddenField runat="server" ID="selectedCounty" />
    <asp:HiddenField runat="server" ID="selectedAPN" />
    <asp:HiddenField runat="server" ID="selectedOwner1First" />
    <asp:HiddenField runat="server" ID="selectedOwner1Last" />
    <asp:HiddenField runat="server" ID="selectedOwner2First" />
    <asp:HiddenField runat="server" ID="selectedOwner2Last" />
    <asp:Table runat="server" ID="tblResults">
    </asp:Table>
    <div class="formElement formSubmit"><asp:Button runat="server" Text="Continue" 
            ID="cmdContinue" PostBackUrl="~/Order.aspx" /></div>
</div>

</asp:Content>
