<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webMaison.aspx.cs" Inherits="prjWebCsRemax.webCritereMaison" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
        
        .body {
            background-image: url('Images/REMAX_Number1_Drawing_Transparent_Web.png');
        }
    </style>
    
</head>
<body class="body">
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnFiltrer" runat="server" BackColor="#4242FF" Font-Bold="True" Height="38px" OnClick="btnFiltrer_Click" Text="Filter" Width="179px" />
            <br />
            <asp:Panel ID="panCritere" runat="server" GroupingText="+Les critères de recherche" Visible="False">
                <br />
                <br />
                <asp:DropDownList ID="lstCboType" runat="server" AutoPostBack="True">
                </asp:DropDownList>
                <br />
                <br />
                <asp:DropDownList ID="lstCboRegion" runat="server" AutoPostBack="True">
                </asp:DropDownList>
                <br />
                <br />
                <asp:DropDownList ID="lstCboVille" runat="server" AutoPostBack="True">
                </asp:DropDownList>
                <br />
                <br />
                <asp:DropDownList ID="lstCboPrix" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="100000 ">100 000 $</asp:ListItem>
                    <asp:ListItem Value="150000">150 000 $</asp:ListItem>
                    <asp:ListItem Value="200000">200 000 $</asp:ListItem>
                    <asp:ListItem Value="250000">250 000 $</asp:ListItem>
                    <asp:ListItem Value="300000">300 000 $</asp:ListItem>
                    <asp:ListItem Value="350000">350 000 $</asp:ListItem>
                    <asp:ListItem Value="400000">400 000 $</asp:ListItem>
                    <asp:ListItem Value="450000">450 000 $</asp:ListItem>
                    <asp:ListItem Value="500000">500 000 $</asp:ListItem>
                    <asp:ListItem Value="550000">550 000 $</asp:ListItem>
                    <asp:ListItem Value="600000">600 000 $</asp:ListItem>
                    <asp:ListItem Value="650000">650 000 $</asp:ListItem>
                    <asp:ListItem Value="700000">700 000 $</asp:ListItem>
                    <asp:ListItem Value="750000">750 000 $</asp:ListItem>
                    <asp:ListItem Value="800000">800 000 $</asp:ListItem>
                    <asp:ListItem Value="850000">850 000 $</asp:ListItem>
                    <asp:ListItem Value="900000">900 000 $</asp:ListItem>
                    <asp:ListItem Value="950000">950 000 $</asp:ListItem>
                    <asp:ListItem Value="1000000">1 000 000 $</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:RadioButtonList ID="lstRadBtnChambre" runat="server">
                    <asp:ListItem Value="0">0+</asp:ListItem>
                    <asp:ListItem Value="1">1+</asp:ListItem>
                    <asp:ListItem Value="2">2+</asp:ListItem>
                    <asp:ListItem Value="3">3+</asp:ListItem>
                    <asp:ListItem Value="4">4+</asp:ListItem>
                    <asp:ListItem Value="5">5+</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <br />
                <asp:Button ID="btnTrouver" runat="server" BackColor="#4242FF" Font-Bold="True" Height="37px" OnClick="btnTrouver_Click" Text="Appliquer" Width="186px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="btnLinkEffacr" runat="server" Font-Bold="True" ForeColor="Red" OnClick="btnLinkEffacr_Click">X supprimer les critères</asp:LinkButton>
            </asp:Panel>
        </div>
        <br />
        <br />
        <br />
        <asp:GridView ID="gridMaison" runat="server" BackColor="Black" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnContacter" runat="server" BackColor="#4242FF" Font-Bold="True" Height="66px" OnClick="btnContacter_Click" Text="Contacter" Width="294px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="btnLinkRetour" runat="server" OnClick="btnLinkRetour_Click">Retourner à la page d&#39;accueil</asp:LinkButton>
    </form>
</body>
</html>
