using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP6_GRUPO_15.clases
{
    public class Conexion
    {
        
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        
        // CONSTRUCTOR
        public Conexion()
        {

        }

        // OBTENGO CONEXIÓN CON LA BASE DE DATOS Y ABRO ESA CONEXIÓN ( ".Open" )
        public SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        // OBTENGO VARIABLE DONDE ALMACENO LA TABLA PEDIDA EN LA CONSULTA QUE RECIBE COMO PARÁMETRO
        // ESTE MÉTODO TAMBIÉN ABRE LA CONEXIÓN YA QUE HACE LLAMADA AL METODO OBTENER CONEXIÓN
        public SqlDataAdapter ObtenerAdaptador(string consultaSql)
        {
            SqlDataAdapter sqlDataAdapter;

            try
            {
                sqlDataAdapter = new SqlDataAdapter( consultaSql, ObtenerConexion() );
                return sqlDataAdapter;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        // RECIBE EL SQLCONNECTION ABIERTO EN EL MÉTODO ABRIR CONEXIÓN Y LO CIERRA
        public void CerrarConexion(SqlConnection conexion)
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        // EJECUTAR EL PROCEDIMIENTO ALMACENADO
        public int EjecutarProcedimientoAlmacenado(SqlCommand comandoSQL, string nombreProcedimientoAlmacenado) //comandoSQL recibe tiene los parametros incluidos
        {
            int FilasCambiadas;

            SqlConnection Conexion = ObtenerConexion();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand = comandoSQL;

            sqlCommand.Connection = Conexion;
            sqlCommand.CommandType = CommandType.StoredProcedure;   /// INDICO QUE SE TRATA DE UN PROCEDIMIENTO ALMACENADO
            sqlCommand.CommandText = nombreProcedimientoAlmacenado; /// INDICO EL NOMBRE DEL PROCEDIMIENTO ALMACENADO
            FilasCambiadas = sqlCommand.ExecuteNonQuery();          /// EJECUTO EL PROCEDIMIENTO ALMACENADO

            Conexion.Close();

            return FilasCambiadas;
        }

    }
}