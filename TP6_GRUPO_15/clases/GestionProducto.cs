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

        private DataTable ObtenerTabla(string nombreTabla, string consultaSQL)
        {
            DataSet dataSet = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter sqlDataAdapter = datos.ObtenerAdaptador(consultaSQL);
            sqlDataAdapter.Fill(dataSet, nombreTabla);
            return dataSet.Tables[nombreTabla];
        }

        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("productos", "SELECT * FROM Productos");
        }

        public GestionProducto(int ID, string NombreProducto, string Cant_X_Unidad, decimal Precio_X_Unidad)
        {
         
        }

        private void ArmarParametrosProductosEliminar(ref SqlCommand Comando, Productos productos)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", System.Data.SqlDbType.Int);
            SqlParametros.Value = productos.Id;
        }

        private void ArmarParametrosProductos(ref SqlCommand Comando, Productos Producto)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Id", System.Data.SqlDbType.Int);
            SqlParametros.Value = Producto.Id;
            SqlParametros = Comando.Parameters.Add("@Nombre_Producto", System.Data.SqlDbType.Int);
            SqlParametros.Value = Producto.Nombre_Producto;
            SqlParametros = Comando.Parameters.Add("@CantidadPorUnidad", System.Data.SqlDbType.Int);
            SqlParametros.Value = Producto.Cant_x_Unidad;
            SqlParametros = Comando.Parameters.Add("@PrecioUnidad", System.Data.SqlDbType.Int);
            SqlParametros.Value = Producto.Precio_Unidad;
        }

        public bool EliminarProducto(Productos producto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ArmarParametrosProductosEliminar(ref sqlCommand, producto);
            AccesoDatos aceesoDatos = new AccesoDatos();
            int FilasInsertadas = aceesoDatos.EjecutarProcedimientoAlmacenado(sqlCommand, "spEliminarProducto");
            if (FilasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}