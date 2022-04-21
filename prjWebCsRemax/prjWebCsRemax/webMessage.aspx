<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webMessage.aspx.cs" Inherits="prjWebCsRemax.webMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 1114px;
        }
        .auto-style3 {
            width: 840px;
            background-color: #BBCCFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">LAISSEZ UN MESSAGE ICI</h1>
            <h2 class="auto-style1">Redaction d&#39;un Nouveau Message</h2>
            <hr class="auto-style2" />
            <br />
            <table align="center" class="auto-style3">
                <tr>
                    <td><strong>Envoyeur: </strong> </td>
                    <td>
                        
                        <asp:TextBox ID="txtEnvoyeur" runat="server" TextMode="Email"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td><strong>Destinataire : </strong> </td>
                    <td>
                        <asp:DropDownList ID="cboDestinaires" runat="server" Width="540px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><strong>Titre Message :</strong></td>
                    <td>
                        <asp:TextBox ID="txtTitre" runat="server" Width="540px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align:top"><strong>Contenu Message:</strong></td>
                    <td>
                        <asp:TextBox ID="txtMessage" runat="server" Height="459px" TextMode="MultiLine" Width="540px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnEnvoyer" runat="server" Text="Envoyer" OnClick="btnEnvoyer_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnEffacer" runat="server" Text="Recommencer" OnClick="btnEffacer_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:LinkButton ID="btnLinkRetour" runat="server" OnClick="btnLinkRetour_Click">Retourner à la page d&#39;accueil</asp:LinkButton>
    </form>
</body>
</html>
