using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_15.clases
{
    public class GestionProducto
    {

        // CONSTRUCTORES
        public GestionProducto()
        {

        }

        // OBTENGO "DataTable" CON LOS CAMPOS PEDIDOS EN "consultaSQL"
        private DataTable ObtenerTabla(string nombreTabla, string consultaSQL)
        {
            DataSet dataSet = new DataSet();
            Conexion datos = new Conexion();
            
            SqlDataAdapter sqlDataAdapter = datos.ObtenerAdaptador(consultaSQL);
            
            sqlDataAdapter.Fill(dataSet, nombreTabla);

            return dataSet.Tables[nombreTabla];
        }

        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("productos", "SELECT * FROM Productos");
        }

        // MÉTODO UTILIZADO PARA ELIMINAR LOS PRODUCTOS DE LA BASE DE DATOS
        public void EliminarProducto(int IDProducto)
        {
            // ESTABLECER CONEXIÓN A BASE DE DATOS SQL SERVER
            Conexion conexion = new Conexion();

            // ESTABLEZCO CONSULTA SQL QUE SE DESEA EJECUTAR ( ELIMINACIÓN POR ID )
            string ConsultaSQL = "DELETE FROM Productos WHERE IdProducto = " + IDProducto;

            SqlCommand SQLCommand = new SqlCommand();
            SQLCommand.CommandText = ConsultaSQL; // ESTABLEZCO CONSULTA
            SQLCommand.Connection = conexion.ObtenerConexion(); // ESTABLEZCO CONEXIÓN

            // EJECUTAR CONSULTA
            SQLCommand.ExecuteNonQuery(); // USADO PARA INSERT, UPDATE, DELETE
        }


    }
}