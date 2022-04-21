<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webPizza.aspx.cs" Inherits="prjWebCsAdoDataset.webPizza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #CC3300;
        }
        body{
            background-color:sandybrown;
        }
        marquee{
            background-color:red;
            color:white;
            font-weight:bold;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">LASALLE PIZZA HURTS</h1>
        </div>
    <hr />
    <marquee>
        The best Pizzeria in Montreal, We satisfy all types of clientele ( Italian, Arabic, Chinese, Indian, Brazilios and Africans ) , Our prices are very low for the Students

    </marquee>
    <hr />
        <table class="auto-style2">
            <tr>
                <td rowspan="2" style="vertical-align:top">
                    <asp:Panel ID="panPizza" runat="server" BackColor="#FDE9D9" Font-Bold="True" GroupingText="Client and Pizza Identification " Height="440px" Width="450px">
                        <table class="auto-style2">
                            <tr>
                                <td>
                                    <asp:Label ID="lblTelephone" runat="server" Text="Client Telephone :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtTelephone" runat="server" Font-Bold="True" ForeColor="#663300" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <asp:Label ID="lblName" runat="server" Text="Client Name :"></asp:Label>
                                </td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="txtName" runat="server" Font-Bold="True" ForeColor="#663300" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            
                            <tr>
                                <td>
                                    <asp:Label ID="lblDelivery" runat="server" Text="For Delivery ? :"></asp:Label>
                                </td>
                                <td>
                                    <asp:CheckBox ID="chkDelivery" runat="server" Font-Bold="True" AutoPostBack="True"  />
                                </td>
                            </tr>
                            <tr>
                                <td style="vertical-align:top">
                                    <asp:Label ID="lblAddress" runat="server" Text="Client Address :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtAddress" runat="server" Font-Bold="True" ForeColor="#663300" Height="60px" TextMode="MultiLine" Width="200px" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblPizza" runat="server" Text="Select Pizza :"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="cboPizzas" runat="server" AutoPostBack="True" Width="200px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td style="vertical-align:top">
                                    <asp:Label ID="lblSize0" runat="server" Text="Select Size :"></asp:Label>
                                </td>
                                <td>
                                    <asp:ListBox ID="lstSizes" runat="server" AutoPostBack="True" Width="200px"></asp:ListBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="vertical-align:top">
                                    <asp:Label ID="lblSize1" runat="server" Text="Select Toppings :"></asp:Label>
                                </td>
                                <td>
                                    <asp:CheckBoxList ID="lstChkToppings" runat="server" AutoPostBack="True">
                                    </asp:CheckBoxList>
                                </td>
                            </tr>
                            <tr>
                                <td style="vertical-align:top">
                                    <asp:Label ID="Label1" runat="server" Text="Select Crust :"></asp:Label>
                                </td>
                                <td>
                                    <asp:RadioButtonList ID="lstRadCrusts" runat="server" >
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td style="vertical-align:top">

                    <asp:Panel ID="panPricing" runat="server" BackColor="#FDE9D9" Font-Bold="True" GroupingText="Order Pricing Evaluation" Height="220px" Width="400px">
                        <asp:Literal ID="litPricing" runat="server"></asp:Literal>
                        <br />
                        <asp:Button ID="btnOrder" runat="server" Font-Bold="True" Text="Order Now" Width="193px" />
                    </asp:Panel>

                </td>
            </tr>
            <tr>
                
                <td style="vertical-align:top">
                    <asp:Panel ID="panOrder" runat="server" BackColor="#FDE9D9" Font-Bold="True" GroupingText="Order Information" Height="220px" Width="400px">
                        <asp:Literal ID="litInfo" runat="server"></asp:Literal>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </form>
    </body>
</html>
