<%@ Page Title="" Language="C#" MasterPageFile="~/PTCOrderSite.Master" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="PTCOrderSite.MainMenu" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h1>Welcome <% Response.Write(Session["username"]); %></h1>

    <div class="accordion">

        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

        <asp:Accordion
            ID="Accordion1"
            CssClass="accordion accordionMainMenu"
            HeaderCssClass="accordionHeader"
            HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent"
            RequireOpenedPane="false"
            FadeTransitions="true"
            SelectedIndex="1"
            runat="server">
            <Panes>
                <asp:AccordionPane runat="server">
                    <Header>Account<span class="accordionHeaderExpand"></span></Header>
                    <Content>
                        <table class="accordionBorder">
                            <tr>
                                <td class="tableFirstColumn"><a href="#">Account Details</a></td>
                                <td class="tableSecondColumn"></td>
                                <td class="tableThirdColumn"></td>
                                <td class="tableFourthColumn"></td>
                            </tr>
                        </table>
                    </Content>
                </asp:AccordionPane>
                <asp:AccordionPane ID="AccordionPane1" runat="server">
                    <Header>Functions<span class="accordionHeaderExpand"></span></Header>
                    <Content>
                        <table class="accordionBorder">
                            <tr>
                                <td class="tableFirstColumn"><a href="./EnterAddress.aspx">Place an Order</a></td>
                                <td class="tableSecondColumn"></td>
                                <td class="tableThirdColumn"></td>
                                <td class="tableFourthColumn"></td>
                            </tr>

                            <tr>
                                <td class="tableFirstColumn"><a href="#">Add Comments to an Order</a></td>
                                <td class="tableSecondColumn"></td>
                                <td class="tableThirdColumn"></td>
                                <td class="tableFourthColumn"></td>
                            </tr>

                            <tr>
                                <td class="tableFirstColumn"><a href="#">GFE Rate Quote</a></td>
                                <td class="tableSecondColumn"></td>
                                <td class="tableThirdColumn"></td>
                                <td class="tableFourthColumn"></td>
                            </tr>
                        </table>
                    </Content>
                </asp:AccordionPane>
                <asp:AccordionPane ID="AccordionPane2" runat="server">
                    <Header>Net Sheets<span class="accordionHeaderExpand"></span></Header>
                    <Content>
                        <table class="accordionBorder">
                            <tr>
                                <td class="tableFirstColumn"><a href="#">New Seller's Net Sheet</a></td>
                                <td class="tableSecondColumn"></td>
                                <td class="tableThirdColumn"></td>
                                <td class="tableFourthColumn"></td>
                            </tr>

                            <tr>
                                <td class="tableFirstColumn"><a href="#">New Buyer's Net Sheet</a></td>
                                <td class="tableSecondColumn"></td>
                                <td class="tableThirdColumn"></td>
                                <td class="tableFourthColumn"></td>
                            </tr>

                            <tr>
                                <td class="tableFirstColumn"><a href="#">Current Net Sheets</a></td>
                                <td class="tableSecondColumn"></td>
                                <td class="tableThirdColumn"></td>
                                <td class="tableFourthColumn"></td>
                            </tr>
                        </table>
                    </Content>
                </asp:AccordionPane>
            </Panes>
        </asp:Accordion>
    </div>
</asp:Content>

