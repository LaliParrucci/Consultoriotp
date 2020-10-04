using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Consultorio.DataAccessLayer
{
    class DBHelper
    {
        private string string_conexion;
        private static DBHelper instance = new DBHelper();

        private DBHelper()
        {
            string_conexion = @"Data Source=desktop-7t95495;Initial Catalog=consultorio_odontologico;Integrated Security=True";
            //string_conexion = @"Data Source=DESKTOP-LNM71CI\SQLEXPRESS;Initial Catalog=consultorio_odontologico;Persist Security Info=True;User ID=sa;Password=19671970";
            //string_conexion = @"Data Source=LAPTOP-E7G93F2V\SQLEXPRESS;Initial Catalog=consultorio_odontologico;Integrated Security=True";
            //string_conexion = @"Data Source=DESKTOP-0RHOTN8\SQLEXPRESS;Initial Catalog=consultorio_odontologico;Integrated Security=True";
        }

        public static DBHelper GetDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }


        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public int EjecutarSQLConParametros(string strSql, Dictionary<string, object> parametros = null)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null/* TODO Change to default(_) if this is not a reference type */;
            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                // Establece que conexión usar
                conexion.ConnectionString = string_conexion;
                // Abre la conexión
                conexion.Open();
                t = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                //Agregamos a la colección de parámetros del comando los filtros recibidos
                foreach (var item in parametros)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                    t.Rollback();
            }
            finally
            {
                // Cierra la conexión 
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                conexion.Dispose();
            }
            return rtdo;
        }

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.

        //SIN PARAMETROS

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public int EjecutarSQL(string strSql)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null/* TODO Change to default(_) if this is not a reference type */;
            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                // Establece que conexión usar
                conexion.ConnectionString = string_conexion;
                // Abre la conexión
                conexion.Open();
                t = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                    t.Rollback();
            }
            finally
            {
                // Cierra la conexión 
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                conexion.Dispose();
            }
            return rtdo;
        }




        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public DataTable ConsultaSQL(string strSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }

        /// Resumen:
        ///      Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        ///      La función recibe por valor una sentencia sql como string y un diccionario de objetos como parámetros
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public DataTable ConsultaSQLConParametros(string sqlStr, Dictionary<string, object> prs)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                foreach (var item in prs)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(cnn);
            }
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

        public void abm(string sentenciaSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sentenciaSql;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }

        }
    }
}
