<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webCoursSearchDataControl.aspx.cs" Inherits="prjWebCsAdoDataset.webCoursSearchDataControl" %>

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
            <td class="tdListbox">Choisir un cours<br />
                <asp:ListBox ID="lstCours" runat="server" AutoPostBack="True" Font-Bold="True" DataSourceID="datCoursList" DataTextField="Numero" DataValueField="RefCours" OnSelectedIndexChanged="lstCours_SelectedIndexChanged"></asp:ListBox>
                <asp:SqlDataSource ID="datCoursList" runat="server" ConnectionString="<%$ ConnectionStrings:teccartDBSqlConnectionString %>" SelectCommand="SELECT [RefCours], [Numero] FROM [Cours]"></asp:SqlDataSource>
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
                                <asp:Button ID="btnAjouter" runat="server" CssClass="button"  Text="Ajouter"   />
                            </td>
                        </tr>
                        <tr>
                            <td>Titre:</td>
                            <td>
                                <asp:TextBox ID="txtTitre" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnModifier" runat="server" CssClass="button" Text="Modifier"   />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Duree:</td>
                            <td class="auto-style7">
                                <asp:TextBox ID="txtDuree" runat="server" Width="72px"></asp:TextBox>
                                &nbsp; Heures</td>
                            <td class="auto-style7">
                                <asp:Button ID="btnSupprimer" runat="server" CssClass="button" Text="Supprimer"   OnClientClick="return confirm('Voulez vous suprimez ce cours')" />
                            </td>
                        </tr>
                        <tr>
                            <td>Professeur</td>
                            <td>
                                <asp:TextBox ID="txtProfesseur" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnSauvegarder" runat="server" CssClass="button" Font-Bold="True" Text="Sauvegarder" Width="200px"  />
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:SqlDataSource ID="dataInfoCours" runat="server" ConnectionString="<%$ ConnectionStrings:teccartDBSqlConnectionString %>" SelectCommand="SELECT * FROM [Cours] WHERE ([RefCours] = @RefCours)">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="lstCours" Name="RefCours" PropertyName="SelectedValue" Type="Int32" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                            <td>
                                <asp:Button ID="btnAnnuler" runat="server" CssClass="button" Font-Bold="True" Text="Annuler" Width="200px"  />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="2">
                <asp:GridView ID="gridEtudiants" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Bold="True" GridLines="Horizontal" AutoGenerateColumns="False" DataKeyNames="RefEtudiant" DataSourceID="datEtudiants">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="RefEtudiant" HeaderText="RefEtudiant" InsertVisible="False" ReadOnly="True" SortExpression="RefEtudiant" />
                        <asp:BoundField DataField="Nom" HeaderText="Nom" SortExpression="Nom" />
                        <asp:BoundField DataField="Naissance" HeaderText="Naissance" SortExpression="Naissance" />
                        <asp:BoundField DataField="Moyenne" HeaderText="Moyenne" SortExpression="Moyenne" />
                        <asp:BoundField DataField="Telephone" HeaderText="Telephone" SortExpression="Telephone" />
                        <asp:BoundField DataField="RefCours" HeaderText="RefCours" SortExpression="RefCours" />
                    </Columns>
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
                <asp:SqlDataSource ID="datEtudiants" runat="server" ConnectionString="<%$ ConnectionStrings:teccartDBSqlConnectionString %>" SelectCommand="SELECT * FROM [Etudiants] WHERE ([RefCours] = @RefCours)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="lstCours" Name="RefCours" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
            </td>
            
        </tr>
    </table>
    </form>
    </body>
</html>