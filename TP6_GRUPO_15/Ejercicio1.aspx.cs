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

        //MÉTODO PARA RECARGAR EL GV LUEGO DE CLICKEAR EDITAR
        protected void gvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProductos.EditIndex = e.NewEditIndex;
            CargarGridView();
        }


        protected void gvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
               
        }

        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // BUSCAR FILA DENTRO DEL EDIT ITEM TEMPLATE
            string IDProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_eit_IdProducto")).Text;
            string NombreProducto = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_NombreProducto")).Text;
            string CantXUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_Cantx_Unidad")).Text;
            string PrecioXUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_PrecioUnidad")).Text;

            // CREAR PRODUCTO
            Productos producto = new Productos(Convert.ToInt32(IDProducto), NombreProducto, CantXUnidad, Convert.ToDecimal(PrecioXUnidad));

            // ACTUALIZAR PRODUCTO
            GestionProducto gestionProducto = new GestionProducto();

            gestionProducto.ActualizarProducto(producto);
            gvProductos.EditIndex = -1;
            CargarGridView();
        }
    }
}