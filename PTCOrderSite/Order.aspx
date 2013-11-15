<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="PTCOrderSite.Order" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

<h1>Place Order</h1>

    <div class="accordion">
    
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
            <table class="accordionBorder">
                <tr>
                    <td class="tableFirstColumn">Your Reference #</td>
                    <td class="tableSecondColumn"><asp:TextBox runat="server" ID="referenceNum" CssClass="textbox"></asp:TextBox></td>
                    <td class="tableThirdColumn"></td>
                    <td class="tableFourthColumn"></td>
                </tr>
                <tr>
                    <td class="tableFirstColumn">Person Entering Order<span class="red">*</span></td>
                    <td class="tableSecondColumn"><asp:TextBox runat="server" ID="personEnterOrder" CssClass="textbox"></asp:TextBox></td>
                    <td class="tableThirdColumn">You are the<span class="red">*</span></td>
                    <td class="tableFourthColumn">
                        <asp:DropDownList id="youAreThe" AutoPostBack="True" runat="server" CssClass="dropdown">
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
                    <td class="tableFirstColumn">Transaction Type<span class="red">*</span></td>
                    <td class="tableSecondColumn">
                        <asp:DropDownList id="transactionType" AutoPostBack="True" runat="server" CssClass="dropdown">
                        <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                        <asp:ListItem Value="White"> White </asp:ListItem>
                        <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                        <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                        <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                        <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="tableThirdColumn"></td>
                    <td class="tableFourthColumn"></td>
                </tr>
            </table>
        </Content>
    </asp:AccordionPane>
    <asp:AccordionPane ID="AccordionPane2" runat="server">
        <Header>Escrow Information</Header>
        <Content>
            <table class="accordionBorder">
                <tr>
                    <td class="tableFirstColumn">Office<span class="red">*</span></td>
                    <td class="tableSecondColumn">
                        <asp:DropDownList id="office" AutoPostBack="True" runat="server" CssClass="dropdown">
                        <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                        <asp:ListItem Value="White"> White </asp:ListItem>
                        <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                        <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                        <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                        <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="tableThirdColumn">Escrow Officer<span class="red">*</span></td>
                    <td class="tableFourthColumn">
                        <asp:DropDownList id="escrowOfficer" AutoPostBack="True" runat="server" CssClass="dropdown">
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
                    <td class="tableFirstColumn">Policy Type</td>
                    <td class="tableSecondColumn">
                        <asp:DropDownList id="policyType" AutoPostBack="True" runat="server" CssClass="dropdown">
                        <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                        <asp:ListItem Value="White"> White </asp:ListItem>
                        <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                        <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                        <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                        <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="tableThirdColumn">Est. Closing Date<span class="red">*</span></td>
                    <td class="tableFourthColumn">
                        <asp:TextBox ID="estClosingDate" runat="server" CssClass="textbox"></asp:TextBox>
                        <asp:CalendarExtender ID="CalendarExtenderClosingDate" TargetControlID="estClosingDate" runat="server" />
                    </td>
                </tr>
            </table>
        </Content>
    </asp:AccordionPane>
    <asp:AccordionPane ID="AccordionPane3" runat="server">
        <Header>Escrow Terms Information</Header>
        <Content>
            <table class="accordionBorder">
                <tr>
                    <td class="tableFirstColumn">Purchase Price</td>
                    <td class="tableSecondColumn">$<asp:TextBox runat="server" ID="purchasePrice" CssClass="textbox"></asp:TextBox></td>
                    <td class="tableThirdColumn">Earnest Money Deposit</td>
                    <td class="tableFourthColumn">$<asp:TextBox runat="server" ID="moneyDeposit" CssClass="textbox"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tableFirstColumn"><strong>Commisions</strong></td>
                    <td class="tableSecondColumn"></td>
                    <td class="tableThirdColumn"></td>
                    <td class="tableFourthColumn"></td>
                </tr>
                <tr>
                    <td class="tableFirstColumn">Listing Company</td>
                    <td class="tableSecondColumn"><asp:TextBox runat="server" ID="listingCompany" CssClass="textbox"></asp:TextBox>%</td>
                    <td class="tableThirdColumn">and/or</td>
                    <td class="tableFourthColumn"><asp:TextBox runat="server" ID="listingCompanyAndOr" CssClass="textbox"></asp:TextBox>%</td>
                </tr>
                <tr>
                    <td class="tableFirstColumn">Selling Company</td>
                    <td class="tableSecondColumn"><asp:TextBox runat="server" ID="sellingCompany" CssClass="textbox"></asp:TextBox>%</td>
                    <td class="tableThirdColumn">and/or</td>
                    <td class="tableFourthColumn"><asp:TextBox runat="server" ID="sellingCompanyAndOr" CssClass="textbox"></asp:TextBox>%</td>
                </tr>
            </table>
        </Content>
    </asp:AccordionPane>
    <asp:AccordionPane ID="AccordionPane4" runat="server">
        <Header>Who Pays?</Header>
        <Content>
        <table class="accordionBorder">
                <tr>
                    <td class="tableFirstColumn">Title</td>
                    <td class="tableSecondColumn">
                        <asp:DropDownList id="title" AutoPostBack="True" runat="server" CssClass="dropdown">
                        <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                        <asp:ListItem Value="White"> White </asp:ListItem>
                        <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                        <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                        <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                        <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="tableThirdColumn">Escrow</td>
                    <td class="tableFourthColumn">
                        <asp:DropDownList id="escrow" AutoPostBack="True" runat="server" CssClass="dropdown">
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
                    <td class="tableFirstColumn">Transfer Tax</td>
                    <td class="tableSecondColumn">
                        <asp:DropDownList id="transferTax" AutoPostBack="True" runat="server" CssClass="dropdown">
                        <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                        <asp:ListItem Value="White"> White </asp:ListItem>
                        <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                        <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                        <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                        <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="tableThirdColumn">City Transfer Tax</td>
                    <td class="tableFourthColumn">
                        <asp:DropDownList id="cityTransferTax" AutoPostBack="True" runat="server" CssClass="dropdown">
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
                    <td class="tableFirstColumn">Homeowners Association?</td>
                    <td class="tableSecondColumn"><asp:CheckBox runat="server" ID="homeownersAssoc" /></td>
                    <td class="tableThirdColumn">Name</td>
                    <td class="tableFourthColumn"><asp:TextBox runat="server" ID="name" CssClass="textbox"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tableFirstColumn">Transfer Fee</td>
                    <td class="tableSecondColumn">
                        <asp:DropDownList id="transferFee" AutoPostBack="True" runat="server" CssClass="dropdown">
                        <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                        <asp:ListItem Value="White"> White </asp:ListItem>
                        <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                        <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                        <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                        <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="tableThirdColumn"></td>
                    <td class="tableFourthColumn"></td>
                </tr>
                <tr>
                    <td class="tableFirstColumn">Termite Report</td>
                    <td class="tableSecondColumn">
                        <asp:DropDownList id="termiteReport" AutoPostBack="True" runat="server" CssClass="dropdown">
                        <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                        <asp:ListItem Value="White"> White </asp:ListItem>
                        <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                        <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                        <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                        <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="tableThirdColumn">Termite Work</td>
                    <td class="tableFourthColumn">
                        <asp:DropDownList id="termiteWork" AutoPostBack="True" runat="server" CssClass="dropdown">
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
                    <td class="tableFirstColumn">Roof Report</td>
                    <td class="tableSecondColumn">
                        <asp:DropDownList id="roofReport" AutoPostBack="True" runat="server" CssClass="dropdown">
                        <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                        <asp:ListItem Value="White"> White </asp:ListItem>
                        <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                        <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                        <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                        <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="tableThirdColumn">Home Warranty</td>
                    <td class="tableFourthColumn">
                        <asp:DropDownList id="homeWarranty" AutoPostBack="True" runat="server" CssClass="dropdown">
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
                    <td class="tableFirstColumn">Hazard Disclosure</td>
                    <td class="tableSecondColumn">
                        <asp:DropDownList id="hazardDisclosure" AutoPostBack="True" runat="server" CssClass="dropdown">
                        <asp:ListItem Selected="True" Value="Select"> Select </asp:ListItem>
                        <asp:ListItem Value="White"> White </asp:ListItem>
                        <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                        <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                        <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                        <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="tableThirdColumn">PTC to Order</td>
                    <td class="tableFourthColumn">
                        <asp:DropDownList id="ptcOrder" AutoPostBack="True" runat="server" CssClass="dropdown">
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
    <br />
    <div style="text-align:center"><asp:Button runat="server" ID="cmdSubmit" Text="Submit" 
            onclick="cmdSubmit_Click" CssClass="submitButton"/></div>
    <br />
</asp:Content>
