﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_15
{
    public partial class Ejercicio2Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //método para eliminar productos seleccionados
        protected void btnEliminarSeleccionados_Click(object sender, EventArgs e)
        {
            if (Session["productosSeleccionados"] != null)
            {
                Session["productosSeleccionados"] = null;

               
            }
        }
    }
}