<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webLinq.aspx.cs" Inherits="prjWebCsAdoDataset.webLinq" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        
        .grandtableau {
            width: 1000px;
            border-style: solid;
            border-width: 1px;
            background-color: #AEAEFF;
        }
        .auto-style3 {
            height: 26px;
        }
        .tdListbox {
            height: 26px;
            width: 157px;
        }
        .auto-style5 {
            width: 157px;
            text-align: center;
        }
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            height: 29px;
        }
        .button{
            width:150px;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">INSTITUT TECCART INTERNATIONAL</h1>
        </div>
    <h2 class="auto-style1">Recherche Et Gestion Des Cours </h2>

        <%--Le grandtableau--%>
    <table align="center" class="grandtableau">
        <tr>
            <td class="tdListbox">Choisir un genre<br />
                <asp:ListBox ID="lstGenres" runat="server" AutoPostBack="True" Font-Bold="True" OnSelectedIndexChanged="lstGenres_SelectedIndexChanged" ></asp:ListBox>
                <br />
            </td>
            <td class="auto-style3">
               
                <asp:RadioButtonList ID="LstRadEtudiants" runat="server" AutoPostBack="True" OnSelectedIndexChanged="LstRadEtudiants_SelectedIndexChanged">
                </asp:RadioButtonList>
               
            </td>
            <td class="auto-style3">
               
                <asp:Label ID="lblInfoEtud" runat="server" Font-Bold="True" ForeColor="#993333"></asp:Label>
               
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:GridView ID="gridEtudiants" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Bold="True" GridLines="Horizontal" Width="815px">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>
            </td>
            
        </tr>
    </table>
    </form>
    </body>
</html>

