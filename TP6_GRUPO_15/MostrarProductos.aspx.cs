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
    public partial class SeleccionarP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                if (Session["productosSeleccionados"] != null)
                {
                    GestionProducto gestionProducto = new GestionProducto();
                    gvProductosSeleccionados.DataSource = Session["productosSeleccionados"];
                    gvProductosSeleccionados.DataBind();
                }
            }
        }
    }
}
