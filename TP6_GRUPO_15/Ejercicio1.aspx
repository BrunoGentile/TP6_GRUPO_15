﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP6_GRUPO_15.Ejercicio1" %>

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
            width: 558px;
        }
        .auto-style3 {
            width: 558px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 558px;
            height: 40px;
        }
        .auto-style6 {
            height: 40px;
        }
        .auto-style7 {
            height: 40px;
            width: 190px;
        }
        .auto-style8 {
            width: 190px;
        }
        .auto-style9 {
            height: 23px;
            width: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Productos"></asp:Label>
                    </td>
                    <td class="auto-style7"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:GridView ID="gvProductos" runat="server" BorderColor="#0066CC" BorderStyle="Solid" ShowFooter="True" Width="524px" AllowPaging="True" OnPageIndexChanging="gvProductos_PageIndexChanging" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" OnRowDeleting="gvProductos_RowDeleting" AutoGenerateEditButton="True" OnRowCancelingEdit="gvProductos_RowCancelingEdit" OnRowEditing="gvProductos_RowEditing" OnRowUpdating="gvProductos_RowUpdating" >
                <AlternatingRowStyle BorderColor="#0066CC" BorderStyle="Solid" ForeColor="#0066CC" />
                <Columns>
                    <asp:TemplateField HeaderText="Id Producto">
                        <EditItemTemplate>
                            <asp:Label ID="lbl_eit_IdProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_IdProducto" runat="server" Text='<%# Bind("idProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre Producto">
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvNombreProducto" runat="server" ControlToValidate="txt_eit_NombreProducto">Ingrese un nombre de producto</asp:RequiredFieldValidator>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_NombreProducto" runat="server" Text='<%# Bind("nombreProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cantidad por Unidad">
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_Cantx_Unidad" runat="server" Text='<%# Bind("CantidadPorUnidad") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvCantidadxUnidad" runat="server" ControlToValidate="txt_eit_Cantx_Unidad">Ingrese la cantidad por unidad</asp:RequiredFieldValidator>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_CantidadPorUnidad" runat="server" Text='<%# Bind("cantidadPorUnidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Precio por Unidad">
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_PrecioUnidad" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPrecioxUnidad" runat="server" ControlToValidate="txt_eit_PrecioUnidad">Ingrese el precio por unidad</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="cvPrecioxUnidad" runat="server" ControlToValidate="txt_eit_PrecioUnidad" Operator="GreaterThan" ValueToCompare="0">El precio debe ser mayor a 0</asp:CompareValidator>
                            <br />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_PrecioPorUnidad" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#669999" BorderColor="#0066CC" BorderStyle="Solid" ForeColor="#0099CC" />
                <HeaderStyle BackColor="#000099" ForeColor="#9999FF" />
                <RowStyle BorderColor="#0066CC" ForeColor="#0066CC" />
            </asp:GridView>
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="btnOrdenarDescendente" runat="server" OnClick="btnOrdenarDescendente_Click" Text="Orden descendente" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style9">
                        <asp:Button ID="btnRestablecerOrden" runat="server" OnClick="btnRestablecerOrden_Click" Text="Restablecer orden" />
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
