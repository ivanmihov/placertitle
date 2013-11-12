<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="PTCOrderSite.Order" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

<h1>Place Order</h1>

    <div>
    
<asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
</asp:ToolkitScriptManager>
   
<asp:Accordion 
    ID="Accordion1" 
    CssClass="accordion"
    HeaderCssClass="accordionHeader"
    HeaderSelectedCssClass="accordionHeaderSelected"
    ContentCssClass="accordionContent" 
    runat="server">
<Panes>
    <asp:AccordionPane runat="server">
        <Header>Pane 1</Header>
        <Content>
        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.
        Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.
        Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.            
        </Content>
    </asp:AccordionPane>
    <asp:AccordionPane ID="AccordionPane2" runat="server">
        <Header>Pane 2</Header>
        <Content>
        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.
        Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.
        Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.
        </Content>
    </asp:AccordionPane>
    <asp:AccordionPane ID="AccordionPane3" runat="server">
        <Header>Pane 3</Header>
        <Content>
        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.
        Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.
        Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.
        </Content>
    </asp:AccordionPane>
</Panes>
</asp:Accordion>
   
    </div>

</asp:Content>
