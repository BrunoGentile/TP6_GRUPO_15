<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP6_GRUPO_15.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 10px;
        }
        .auto-style3 {
            width: 10px;
            height: 35px;
        }
        .auto-style4 {
            height: 35px;
        }
        .auto-style5 {
            width: 10px;
            height: 36px;
        }
        .auto-style6 {
            height: 36px;
        }
        .auto-style7 {
            width: 170px;
        }
        .auto-style8 {
            height: 35px;
            width: 170px;
        }
        .auto-style9 {
            height: 36px;
            width: 170px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="LBL_GroupNumb" runat="server" Font-Bold="True" Font-Size="20pt" Text="Grupo N° 15"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style8">
                        <asp:HyperLink ID="HL_EJ1" runat="server" NavigateUrl="~/Ejercicio1.aspx">Ejercicio 1</asp:HyperLink>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style9">
                        <asp:HyperLink ID="HL_EJ2" runat="server" NavigateUrl="~/Ejercicio2Inicio.aspx">Ejercicio 2</asp:HyperLink>
                    </td>
                    <td class="auto-style6"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
