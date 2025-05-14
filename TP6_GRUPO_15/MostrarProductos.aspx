<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarProductos.aspx.cs" Inherits="TP6_GRUPO_15.SeleccionarP" %>

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
            width: 309px;
        }
        .auto-style5 {
            width: 309px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            width: 333px;
        }
        .auto-style8 {
            width: 333px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label1" runat="server" Text="Productos Seleccionados por el Usuario: " Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="Large"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <br />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:GridView ID="gvProductosSeleccionados" runat="server" AllowPaging="True" OnPageIndexChanging="gvProductosSeleccionados_PageIndexChanging" PageSize="14" AutoGenerateColumns="False" BorderColor="#0099FF" ForeColor="#0066CC" OnSelectedIndexChanged="gvProductosSeleccionados_SelectedIndexChanged">
                            <Columns>
                                <asp:TemplateField HeaderText="IdProducto">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_idProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="NombreProducto">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="IdProveedor">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_idProveedor" runat="server" Text='<%# Bind("IdProveedor") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="PrecioUnidad">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_PrecioUnidad" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <HeaderStyle BackColor="#000099" BorderColor="#0066CC" BorderStyle="Solid" ForeColor="#CCCCFF" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:HyperLink ID="Hl_volverAlIncio" runat="server" NavigateUrl="~/Ejercicio2.aspx">Volver al Incio</asp:HyperLink>
                    </td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
