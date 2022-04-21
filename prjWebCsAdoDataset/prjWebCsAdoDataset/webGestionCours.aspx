<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webGestionCours.aspx.cs" Inherits="prjWebCsAdoDataset.webGestionCours" %>

<!DOCTYPE html>

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
            <td class="tdListbox">Choisir un cours<br />
                <asp:ListBox ID="lstCours" runat="server" AutoPostBack="True" Font-Bold="True" OnSelectedIndexChanged="lstCours_SelectedIndexChanged"></asp:ListBox>
                <br />
            </td>
            <td class="auto-style3">
                <asp:Panel ID="Panel1" runat="server" Font-Bold="True" GroupingText="Info aux cours choisi" Height="210px">
                    <table class="auto-style6">
                        <tr>
                            <td>Numero:</td>
                            <td>
                                <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnAjouter" runat="server" CssClass="button"  Text="Ajouter" OnClick="btnAjouter_Click"  />
                            </td>
                        </tr>
                        <tr>
                            <td>Titre:</td>
                            <td>
                                <asp:TextBox ID="txtTitre" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnModifier" runat="server" CssClass="button" Text="Modifier" OnClick="btnModifier_Click"  />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Duree:</td>
                            <td class="auto-style7">
                                <asp:TextBox ID="txtDuree" runat="server" Width="72px"></asp:TextBox>
                                &nbsp; Heures</td>
                            <td class="auto-style7">
                                <asp:Button ID="btnSupprimer" runat="server" CssClass="button" Text="Supprimer" OnClick="btnSupprimer_Click"  />
                            </td>
                        </tr>
                        <tr>
                            <td>Professeur</td>
                            <td>
                                <asp:TextBox ID="txtProfesseur" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnSauvegarder" runat="server" CssClass="button" Font-Bold="True" Text="Sauvegarder" Width="200px" OnClick="btnSauvegarder_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnAnnuler" runat="server" CssClass="button" Font-Bold="True" Text="Annuler" Width="200px" OnClick="btnAnnuler_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>
