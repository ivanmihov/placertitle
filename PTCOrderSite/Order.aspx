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
        <Header>General Information</Header>
        <Content>
            <table border="0">
                <tr>
                <td class="textboxTitle">Your Reference #</td>
                <td><asp:TextBox runat="server" ID="referenceNum"></asp:TextBox></td>
                </tr>
                <tr>
                <td class="textboxTitle">Person Entering Order</td>
                <td><asp:TextBox runat="server" ID="personEnterOrder"></asp:TextBox></td>
                <td class="textboxTitle">You are the</td>
                <td>
                    <asp:DropDownList id="youAreThe" AutoPostBack="True" runat="server">
                    <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                    <asp:ListItem Value="White"> White </asp:ListItem>
                    <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                    <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                    <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                    <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                    </asp:DropDownList>
                </td>
                </tr>
                <tr>
                <td class="textboxTitle">Transaction Type</td>
                <td>
                    <asp:DropDownList id="transactionType" AutoPostBack="True" runat="server">
                    <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                    <asp:ListItem Value="White"> White </asp:ListItem>
                    <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                    <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                    <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                    <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                    </asp:DropDownList>
                </td>
                </tr>
            </table>
        </Content>
    </asp:AccordionPane>
    <asp:AccordionPane ID="AccordionPane2" runat="server">
        <Header>Escrow Information</Header>
        <Content>
            <tr>
                <td class="textboxTitle">Office</td>
                <td>
                    <asp:DropDownList id="office" AutoPostBack="True" runat="server">
                    <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                    <asp:ListItem Value="White"> White </asp:ListItem>
                    <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                    <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                    <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                    <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="textboxTitle">Escrow Officer</td>
                <td>
                    <asp:DropDownList id="escrowOfficer" AutoPostBack="True" runat="server">
                    <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                    <asp:ListItem Value="White"> White </asp:ListItem>
                    <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                    <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                    <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                    <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                    </asp:DropDownList>
                </td>
              </tr>
              <tr>
                <td class="textboxTitle">Policy Type</td>
                <td>
                    <asp:DropDownList id="policyType" AutoPostBack="True" runat="server">
                    <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                    <asp:ListItem Value="White"> White </asp:ListItem>
                    <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                    <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                    <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                    <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="textboxTitle">Est. Closing Date</td>
                <td>
                    <asp:TextBox ID="estClosingDate" runat="server"></asp:TextBox>
                    <asp:CalendarExtender ID="CalendarExtenderClosingDate" TargetControlID="estClosingDate" runat="server" />
                </td>
              </tr>
        </Content>
    </asp:AccordionPane>
    <asp:AccordionPane ID="AccordionPane3" runat="server">
        <Header>Escrow Terms Information</Header>
        <Content>
        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.
        Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.
        Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.
        </Content>
    </asp:AccordionPane>
    <asp:AccordionPane ID="AccordionPane4" runat="server">
        <Header>Who Pays?</Header>
        <Content>
        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.
        Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.
        Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.
        </Content>
    </asp:AccordionPane>
    <asp:AccordionPane ID="AccordionPane5" runat="server">
        <Header>Payoff Information</Header>
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
