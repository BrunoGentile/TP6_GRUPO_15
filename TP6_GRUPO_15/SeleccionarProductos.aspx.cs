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
                Session["Precio"] = "DESC";
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
            int proveedor = Convert.ToInt32(((Label)gvMostrarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProveedor")).Text);
            decimal precioUnitario = Convert.ToDecimal(((Label)gvMostrarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_PrecioUnitario")).Text);

            
            DataTable productos = Session["productosSeleccionados"] as DataTable;
            // Si la tabla existe pero no tiene la columna "IdProducto", se asume que está mal creada
            // o si directamente es null, se crea una nueva tabla con la estructura correcta
            if (productos == null || !productos.Columns.Contains("IdProducto"))
            {
                productos = new DataTable();
                // Define las columnas que va a tener la tabla
                productos.Columns.Add("IdProducto", typeof(int));
                productos.Columns.Add("NombreProducto", typeof(string));
                productos.Columns.Add("IdProveedor", typeof(int));
                productos.Columns.Add("PrecioUnidad", typeof(decimal));
            }

            // Verificar si ya está (por ID)
            bool existe = productos.AsEnumerable().Any(row => row.Field<int>("IdProducto") == idProducto);

            // Si el producto no está en la tabla, se agrega una nueva fila
            if (!existe)
            {
                productos.Rows.Add(idProducto, nombreProducto, proveedor, precioUnitario);
            }

            // Se guarda la tabla actualizada en la sesión
            Session["productosSeleccionados"] = productos;

            // Genera un texto con los nombres de todos los productos seleccionados
            var nombres = productos.AsEnumerable().Select(r => r.Field<string>("NombreProducto"));
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

        protected void btnOrdenarPrecio_Click(object sender, EventArgs e)
        {
            string Precio = Session["Precio"] != null ? Session["Precio"].ToString() : "ASC";
            GestionProducto gestionProductos = new GestionProducto();
            gvMostrarProductos.DataSource = gestionProductos.ObtenerProductosPorPrecio(Precio); // RETORNA UN DataTable
            gvMostrarProductos.DataBind();
        }
    }
 }