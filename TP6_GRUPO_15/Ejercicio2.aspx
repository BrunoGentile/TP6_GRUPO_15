<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP6_GRUPO_15.Ejercicio2Inicio" %>

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
            width: 60px;
        }
        .auto-style7 {
            width: 95px;
        }
        .auto-style9 {
            width: 60px;
            height: 32px;
        }
        .auto-style10 {
            height: 32px;
            width: 95px;
        }
        .auto-style11 {
            height: 32px;
        }
        .auto-style12 {
            width: 60px;
            height: 31px;
        }
        .auto-style13 {
            height: 31px;
            width: 95px;
        }
        .auto-style14 {
            height: 31px;
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
                        <asp:Label ID="lblInicio" runat="server" Font-Bold="True" Font-Size="25pt" Text="Inicio"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style11">
                        <asp:HyperLink ID="hlSeleccionarProductos" runat="server" NavigateUrl="~/SeleccionarProductos.aspx">Seleccionar Productos</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12"></td>
                    <td class="auto-style13">
                    </td>
                    <td class="auto-style14">
                        <asp:LinkButton ID="lbEliminarProductos" runat="server" OnClick="btnEliminarSeleccionados_Click">Eliminar Productos seleccionados</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10">
                    </td>
                    <td class="auto-style11">
                        <asp:HyperLink ID="hlMostrarProductos" runat="server" NavigateUrl="~/MostrarProductos.aspx">Mostrar Productos</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
