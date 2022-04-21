<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webConnection.aspx.cs" Inherits="prjWebReplirListAdoDataSet.webConnection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 513px;
        }
        .auto-style3 {
            width: 513px;
            height: 57px;
            text-align: center;
        }
    </style>
</head>
<body style="height: 261px">
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" GroupingText="Identifiant de l'etudiant">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">Numero Etudiant:</td>
                        <td>
                            <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Mot de passe:</td>
                        <td>
                            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Button ID="btnCommencer" runat="server" Text="Commencer" Width="279px" />
                        </td>
                        <td>
                            <asp:Button ID="btnEffacer" runat="server" Text="Effacer" Width="314px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3" colspan="2">
                            <asp:Label ID="lblRemarque" runat="server" Text="Label"></asp:Label>
                        </td>
                        
                    </tr>
                </table>
            </asp:Panel>
        </div>
        <asp:Panel ID="Panel2" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
