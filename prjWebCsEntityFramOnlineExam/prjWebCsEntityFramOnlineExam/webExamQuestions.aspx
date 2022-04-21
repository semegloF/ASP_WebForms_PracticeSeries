<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webExamQuestions.aspx.cs" Inherits="prjWebCsEntityFramOnlineExam.webExamQuestions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 600px;
            border-style: solid;
            border-width: 1px;
            background-color: #CCFFFF;
        }
        .auto-style3 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1><strong>UNIVERSITE DU CAIRE</h1>
            <h2>EXAMEN DE PROGRAMMATION EN LIGNE</strong></h2>
        </div>
    <table align="center" cellspacing="4" class="auto-style2">
        <tr>
            <td colspan="2">
                <asp:Label ID="lblQuestion1" runat="server" Font-Bold="True"></asp:Label>
            </td>
           
        </tr>
        <tr>
            <td colspan="2" class="auto-style3">
                <asp:RadioButtonList ID="lstRadReponsesQ1" runat="server">
                </asp:RadioButtonList>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnValiderQ1" runat="server" OnClick="btnValiderQ1_Click" Text="Valider" />
            </td>
            <td>
                <asp:Label ID="lblNote1" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
        <br /><br />
    <table align="center" cellspacing="4" class="auto-style2">
        <tr>
            <td colspan="2">
                <asp:Label ID="lblQuestion2" runat="server" Font-Bold="True"></asp:Label>
            </td>
           
        </tr>
        <tr>
            <td colspan="2" class="auto-style3">
                <asp:RadioButtonList ID="lstRadReponsesQ2" runat="server">
                </asp:RadioButtonList>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnValiderQ2" runat="server" OnClick="btnValiderQ2_Click" Text="Valider" />
            </td>
            <td>
                <asp:Label ID="lblNote2" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>
