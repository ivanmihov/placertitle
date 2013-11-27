<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="ValidateAddress.aspx.cs" Inherits="PTCOrderSite.ValidateAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" type="text/javascript">
    function changeSelection() {
        var radioButtons = document.getElementsByName("ctl00$body$AddressSelection");

        for (var i = 0; i < radioButtons.length; i++) {
            if (radioButtons[i].checked == true) {
                // Get the selected button's prefix
                var idPrefix = "body_" + i + "_";

                // Store owner 1 first and owner 2 names as a variable, fields may be null
                var owner1First = document.getElementById(idPrefix + "Owner1First") == null
                    ? "" : document.getElementById(idPrefix + "Owner1First").innerHTML;
                var owner2First = document.getElementById(idPrefix + "Owner2First") == null
                    ? "" : document.getElementById(idPrefix + "Owner2First").innerHTML;
                var owner2Last = document.getElementById(idPrefix + "Owner2Last") == null
                    ? "" : document.getElementById(idPrefix + "Owner2Last").innerHTML;

                // Populate fields
                document.getElementById("body_selectedAddress").value = document.getElementById(idPrefix + "Address").innerHTML;
                document.getElementById("body_selectedCity").value = document.getElementById(idPrefix + "City").innerHTML;
                document.getElementById("body_selectedState").value = document.getElementById(idPrefix + "State").innerHTML;
                document.getElementById("body_selectedZip").value = document.getElementById(idPrefix + "Zip").innerHTML;
                document.getElementById("body_selectedCounty").value = document.getElementById(idPrefix + "County").innerHTML;
                document.getElementById("body_selectedAPN").value = document.getElementById(idPrefix + "APN").innerHTML;
                document.getElementById("body_selectedOwner1First").value = owner1First;
                document.getElementById("body_selectedOwner1Last").value = document.getElementById(idPrefix + "Owner1Last").innerHTML;
                document.getElementById("body_selectedOwner2First").value = owner2First;
                document.getElementById("body_selectedOwner2Last").value = owner2Last;
            }
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
    <asp:HiddenField runat="server" ID="selectedOwner1First"/>
    <asp:HiddenField runat="server" ID="selectedOwner1Last" />
    <asp:HiddenField runat="server" ID="selectedOwner2First" />
    <asp:HiddenField runat="server" ID="selectedOwner2Last" />
    <asp:Table runat="server" ID="tblResults">
    </asp:Table>
    <div class="formElement formSubmit"><asp:Button runat="server" Text="Continue" 
            ID="cmdContinue" PostBackUrl="~/Order.aspx" /></div>
</div>

</asp:Content>
