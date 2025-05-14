using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

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

            datos.ObtenerConexion().Close(); // CIERRO LA CONEXIÓN

            return dataSet.Tables[nombreTabla];
        }

        public DataTable ObtenerProductosConOrden(string orden)
        {
            return ObtenerTabla("productos", "SELECT * FROM Productos ORDER BY IdProducto " + orden);
        }
        public DataTable ObtenerProductosPorPrecio(string Precio)
        {
            return ObtenerTabla("productos", "SELECT * FROM Productos ORDER BY PrecioUnidad " + Precio);
        }
        //public DataTable ObtenerTodosLosProductos()
        //{
        //    return ObtenerTabla("productos", "SELECT * FROM Productos");
        //}

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
            conexion.ObtenerConexion().Close(); // CIERRO LA CONEXIÓN
        }

        // MÉTODO PARA ACTUALIZAR PRODUCTO EN LA BASE DE DATOS
        public void ActualizarProducto(Productos producto)
        {
            // ESTABLECER CONEXIÓN A BASE DE DATOS SQL SERVER
            Conexion conexion = new Conexion();

            // CONSULTA DML ( INSERT INTO [MODIFICACIÓN TABLA SQL] )
            string ConsultaSQL = "UPDATE Productos SET NombreProducto = @nombre, CantidadPorUnidad = @cantidad, PrecioUnidad = @precio WHERE idProducto = @id";

            SqlCommand SQLCommand = new SqlCommand(ConsultaSQL, conexion.ObtenerConexion());

            SQLCommand.Parameters.AddWithValue("@id", producto.Id);
            SQLCommand.Parameters.AddWithValue("@nombre", producto.Nombre_Producto);
            SQLCommand.Parameters.AddWithValue("@cantidad", producto.Cant_x_Unidad);
            SQLCommand.Parameters.AddWithValue("@precio", producto.Precio_Unidad);

            // EJECUTAR CONSULTA
            SQLCommand.ExecuteNonQuery(); // USADO PARA INSERT, UPDATE, DELETE
            conexion.ObtenerConexion().Close(); // CIERRO LA CONEXIÓN
        }
    }
}