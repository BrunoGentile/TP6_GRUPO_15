using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_15.clases;

//(Convert.ToInt32(idProducto));

namespace TP6_GRUPO_15
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( Page.IsPostBack == false )
            {
                CargarGridView();
            }
        }

        // MÉTODO UTILIZADO PARA "MOSTRAR" EL GRIDVIEW ( USARSE SIEMPRE MOSTRAR MODIFICACIONES )
        private void CargarGridView()
        {
            GestionProducto gestionProductos = new GestionProducto();
            gvProductos.DataSource = gestionProductos.ObtenerTodosLosProductos(); // RETORNA UN DataTable
            gvProductos.DataBind();
        }

        // MÉTODO UTILIZADO PARA LA PÁGINACIÓN DEL GRIDVIEW
        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }

        // MÉTODO UTILIZADO PARA BORRAR PRODUCTO SELECCIONADO
        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // OBTENCIÓN DEL ID DEL PRODUCTO A ELIMINAR
            int idProducto = Convert.ToInt32(((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_it_idProducto")).Text);
                
            // ELIMINACIÓN DEL PRODUCTO
            GestionProducto gestionProducto = new GestionProducto();
            gestionProducto.EliminarProducto( idProducto );

            // REFRESCAR GRIDVIEW PARA VISUALIZAR LA MODIFICACIÓN
            CargarGridView();
        }
    }
}