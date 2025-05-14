using System;
using System.Collections.Generic;
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
                Session["productosSeleccionados"] = new List<Productos>();
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

            List<Productos> productos = Session["productosSeleccionados"] as List<Productos>;

            if (!productos.Any(p => p.Id == idProducto))
            {
                productos.Add(new Productos(idProducto, nombreProducto, proveedor, precioUnitario));
            }

            Session["productosSeleccionados"] = productos;

            lblSeleccioandos.Text = "Productos agregados: " + string.Join(" - ", productos.Select(p => p.Nombre_Producto));

        }

        protected void gvMostrarProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }