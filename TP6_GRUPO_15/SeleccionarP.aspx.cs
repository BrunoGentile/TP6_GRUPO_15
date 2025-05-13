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
            // OBTENCIÓN DE LOS VALORES DE LOS CAMPOS DEL PRODUCTO SELECCIONADO:
            string idProducto = ((Label)gvMostrarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProducto")).Text;
            string nombreProducto = ((Label)gvMostrarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_NombreProducto")).Text;
            string idProveedor = ((Label)gvMostrarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProveedor")).Text;
            string precioUnitario = ((Label)gvMostrarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_PrecioUnitario")).Text;

        }

        protected void gvMostrarProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }