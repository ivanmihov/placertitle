<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="ValidateAddress.aspx.cs" Inherits="PTCOrderSite.ValidateAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" type="text/javascript">
    function changeSelection() {
        var radioButtons = document.getElementsByName("ctl00$body$AddressSelection");

        for (var i = 0; i < radioButtons.length; i++) {
            if (radioButtons[i].checked == true) {
                // Get the selected button's prefix
                alert("Old value of the hidden field: " + document.getElementById("body_selectedAddress").value);
                var idPrefix = "body_" + i + "_";
                document.getElementById("body_selectedAddress").value = document.getElementById(idPrefix + "Address").innerHTML;
                alert("New value of the hidden field: " + document.getElementById("body_selectedAddress").value);
            }
        }
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

<h1>Validate Address</h1>

<div class="formBox mediumForm">
    <input type="hidden" id="selectedAddress" />
    <input type="hidden" id="selectedCity" />
    <input type="hidden" id="selectedState" />
    <input type="hidden" id="selectedZip" />
    <input type="hidden" id="selectedCounty" />
    <input type="hidden" id="selectedAPN" />
    <input type="hidden" id="selectedOwner1First" />
    <input type="hidden" id="selectedOwner1Last" />
    <input type="hidden" id="selectedOwner2First" />
    <input type="hidden" id="selectedOwner2Last" />
    <asp:Table runat="server" ID="tblResults">
    </asp:Table>
    <div class="formElement formSubmit"><asp:Button runat="server" Text="Continue" 
            ID="cmdContinue" PostBackUrl="~/Order.aspx" /></div>
</div>

</asp:Content>
