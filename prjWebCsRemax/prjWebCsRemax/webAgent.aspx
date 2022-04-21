<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webAgent.aspx.cs" Inherits="prjWebCsRemax.webCritereAgent" %>

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
            <asp:Button ID="btnFiltrer" runat="server" BackColor="#4242FF" Font-Bold="True" Height="38px" OnClick="btnFiltrer_Click" Text="Filter" Width="179px" />
            <br />
            <asp:Panel ID="panCritere" runat="server" GroupingText="+Les critères de recherche" Visible="False">
                <br />
                <br />
                <asp:DropDownList ID="lstCboNumero" runat="server" AutoPostBack="True">
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
                <asp:DropDownList ID="lstCboLangue" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="Anglais">Anglais</asp:ListItem>
                    <asp:ListItem Value="Francais">Français</asp:ListItem>
                    <asp:ListItem Value="Arabe">Arabe</asp:ListItem>
                    <asp:ListItem Value="Allemand">Allemand</asp:ListItem>
                    <asp:ListItem Value="Espagnol">Espagnol</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:RadioButtonList ID="lstRadBtnGenre" runat="server">
                    <asp:ListItem Value="F">F</asp:ListItem>
                    <asp:ListItem Value="M">M</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <br />
                <asp:Button ID="btnTrouver" runat="server" BackColor="#4242FF" Font-Bold="True" Height="37px" OnClick="btnTrouver_Click" Text="Appliquer" Width="186px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="btnLinkEffacr" runat="server" Font-Bold="True" ForeColor="Red" OnClick="btnLinkEffacr_Click">X supprimer les critères</asp:LinkButton>
            </asp:Panel>
        </div>
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="gridAgents" runat="server" BackColor="Black" CellPadding="4" ForeColor="#333333" GridLines="None">
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
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnContacter" runat="server" BackColor="#4242FF" Font-Bold="True" Height="66px" OnClick="btnContacter_Click" Text="Contacter" Width="294px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="btnLinkRetour" runat="server" OnClick="btnLinkRetour_Click">Retourner à la page d&#39;accueil</asp:LinkButton>
        </div>
    </form>
</body>
</html>
