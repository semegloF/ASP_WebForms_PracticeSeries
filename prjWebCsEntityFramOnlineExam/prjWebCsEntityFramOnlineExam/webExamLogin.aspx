<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webExamLogin.aspx.cs" Inherits="prjWebCsEntityFramOnlineExam.webExamLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .tableau {
            width: 400px;
            background-color: #990033;
            border-radius:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="UNIVERSITE DU CAIRE"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="EXAMEN DE FORMATION EN LIGNE"></asp:Label>
            <br />
            <br />
            <br />
            <table align="center" class="tableau">
                <tr>
                    <td><strong>Numero Etudiant</strong></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><strong>Mot de passe</strong></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtMot2pass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><strong>
                        <asp:Button ID="BtnCommencer" runat="server" Font-Bold="True" Text="Commencer" OnClick="BtnCommencer_Click" />
                        </strong></td>
                    <td class="auto-style1"><strong>
                        <asp:Button ID="btnEffacer" runat="server" Font-Bold="True" Text="Effacer" Width="142px" />
                        </strong></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="#FF3300" Text="Label" Width="100%"></asp:Label>
                    </td>
                    
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="gridEtudiant" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
