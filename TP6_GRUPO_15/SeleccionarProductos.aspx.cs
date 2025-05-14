using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_15.clases;

namespace TP6_GRUPO_15
{
    public partial class MostrarP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Session["orden"] = "ASC"; // Orden por defecto
                CargarGridView();
                
                if (Session["productosSeleccionados"] == null)
                {
                    DataTable tablaSeleccionados = new DataTable();
                    tablaSeleccionados.Columns.Add("Id", typeof(int));
                    tablaSeleccionados.Columns.Add("Nombre_Producto", typeof(string));
                    tablaSeleccionados.Columns.Add("Cant_x_Unidad", typeof(string));
                    tablaSeleccionados.Columns.Add("Precio_Unidad", typeof(decimal));
                    Session["productosSeleccionados"] = tablaSeleccionados;
                }

                lblSeleccioandos.Text = "Productos agregados: ";
            }
        }

        // MÉTODO UTILIZADO PARA MOSTRAR EL GRIDVIEW
        private void CargarGridView()
        {
            string orden = Session["orden"] != null ? Session["orden"].ToString() : "ASC";

            GestionProducto gestionProductos = new GestionProducto();
            gvMostrarProductos.DataSource = gestionProductos.ObtenerProductosConOrden(orden); // RETORNA UN DataTable
            gvMostrarProductos.DataBind();
        }

        protected void gvMostrarProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int idProducto = Convert.ToInt32(((Label)gvMostrarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProducto")).Text);
            string nombreProducto = ((Label)gvMostrarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_NombreProducto")).Text;
            string proveedor = ((Label)gvMostrarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProveedor")).Text;
            decimal precioUnitario = Convert.ToDecimal(((Label)gvMostrarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_PrecioUnitario")).Text);

            DataTable productos = Session["productosSeleccionados"] as DataTable;

            // Verificar si ya está (por ID)
            bool existe = productos.AsEnumerable().Any(row => row.Field<int>("Id") == idProducto);

            if (!existe)
            {
                DataRow nuevaFila = productos.NewRow();
                nuevaFila["Id"] = idProducto;
                nuevaFila["Nombre_Producto"] = nombreProducto;
                nuevaFila["Cant_x_Unidad"] = proveedor; // campo usado para proveedor
                nuevaFila["Precio_Unidad"] = precioUnitario;
                productos.Rows.Add(nuevaFila);
            }

            Session["productosSeleccionados"] = productos;

            // Actualizar Label
            var nombres = productos.AsEnumerable().Select(r => r.Field<string>("Nombre_Producto"));
            lblSeleccioandos.Text = "Productos agregados: " + string.Join(" - ", nombres);

        }

        protected void gvMostrarProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvMostrarProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMostrarProductos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }

        protected void BTN_IDDESC_Click(object sender, EventArgs e)
        {
            Session["orden"] = "DESC"; // ORDEN DESCENDENTE
            CargarGridView();
        }

        protected void BTR_Restart_Click(object sender, EventArgs e)
        {
            Session["orden"] = "ASC"; // ORDEN POR DEFECTO
            CargarGridView();
        }
    }
 }