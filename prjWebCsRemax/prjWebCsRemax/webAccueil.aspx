<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webAccueil.aspx.cs" Inherits="prjWebCsRemax.webAccueil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
  
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            
            
        }
        .body {
            background-image: url('Images/Remax-home-for-for-sale.png');
        }
    </style>
  
</head>
<body  class="body">

    <form id="form1" runat="server">
        <div class="auto-style1">
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <asp:Button ID="btnMaison" runat="server" BackColor="#CC0000" Font-Bold="True" Font-Size="Large" Height="97px" OnClick="btnMaison_Click" Text="Trouver une maison" Width="290px" />
            <asp:Button ID="btnAgent" runat="server" BackColor="#4444FF" Font-Bold="True" Font-Size="Large" Height="96px" OnClick="btnAgent_Click" Text="Trouver un agent" Width="274px" />
        </div>
    </form>

</body>
</html>
