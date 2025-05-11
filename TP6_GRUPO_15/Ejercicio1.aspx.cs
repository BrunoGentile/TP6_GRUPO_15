using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_15.clases;

namespace TP6_GRUPO_15
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            
        }

        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string idProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_it_idProducto")).Text;

            // CREAR PRODUCTO
            Productos producto = new Productos(Convert.ToInt32(idProducto));

            GestionProducto gestion
        }
    }
}