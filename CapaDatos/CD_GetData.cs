using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Claims;

namespace CapaDatos
{
    public class CD_GetData
    {
        private CD_Connection db_connection = new CD_Connection();

        public DataTable ObtenerAlumnos(string p_user, string p_pass)
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "SelectUser";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@userPro", p_user);
            sqlCommand.Parameters.AddWithValue("@passPro", p_pass);
            sqlCommand.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name + ":" + ex.Message);
            }
            db_connection.CloseConnection();
            return dataTable;
        }
        public DataTable InfoUser(int p_user)
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "InfoUser";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@iduser", p_user);
            sqlCommand.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name + ":" + ex.Message);
            }
            db_connection.CloseConnection();
            return dataTable;
        }

        public SqlDataReader reader(int p_user)
        {


            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "sp_get_role_module_options";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@iduser", p_user);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            return reader;
        }

        ///ROL
        public void InsertarRol(string nombreRol)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "insertar_rol";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@nombreRol", nombreRol);
            sqlCommand.ExecuteNonQuery();
            db_connection.CloseConnection();
        }
        public void ActualizarRol(int idRol, string nombreRol, char estado)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "modificar_rol";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@idRol", idRol);
            sqlCommand.Parameters.AddWithValue("@nombreRol", estado);
            sqlCommand.Parameters.AddWithValue("@estado", nombreRol);
            sqlCommand.ExecuteNonQuery();
            db_connection.CloseConnection();
        }
        public void EliminarRol(int idRol)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "eliminar_rol";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@idRol", idRol);
            sqlCommand.ExecuteNonQuery();
            db_connection.CloseConnection();
        }
        public DataTable ObtenerRoles()
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "mostrar_rol";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name + ":" + ex.Message);
            }
            db_connection.CloseConnection();
            return dataTable;
        }

        ///USUARIOS
        public void InsertarUsuario(string username, string clave, int idrol, string nombres, string telefono, string dirDomic, string correo)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "insertar_usuario";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@username", username);
            sqlCommand.Parameters.AddWithValue("@clave", clave);
            sqlCommand.Parameters.AddWithValue("@id_rol", idrol);
            sqlCommand.Parameters.AddWithValue("@nombre_user", nombres);
            sqlCommand.Parameters.AddWithValue("@tel_contacto", telefono);
            sqlCommand.Parameters.AddWithValue("@dir_contacto", dirDomic);
            sqlCommand.Parameters.AddWithValue("@correo", correo);
            sqlCommand.ExecuteNonQuery();
            db_connection.CloseConnection();
        }
        public void ActualizarUser(int idUser, string username, string clave, int idrol, string nombres, string telefono, string dirDomic, string correo)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "modificar_usuario";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@idUser", idUser);
            sqlCommand.Parameters.AddWithValue("@username", username);
            sqlCommand.Parameters.AddWithValue("@clave", clave);
            sqlCommand.Parameters.AddWithValue("@id_rol", idrol);
            sqlCommand.Parameters.AddWithValue("@nombre_user", nombres);
            sqlCommand.Parameters.AddWithValue("@tel_contacto", telefono);
            sqlCommand.Parameters.AddWithValue("@dir_contacto", dirDomic);
            sqlCommand.Parameters.AddWithValue("@correo", correo);

            sqlCommand.ExecuteNonQuery();
            db_connection.CloseConnection();
        }
        public void EliminarUser(int idUser)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "eliminarUsuario";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@idUser", idUser);
            sqlCommand.ExecuteNonQuery();
            db_connection.CloseConnection();
        }
        public DataTable ObtenerUsuarios()
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "mostrar_usuarios";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name + ":" + ex.Message);
            }
            db_connection.CloseConnection();
            return dataTable;
        }
    }
}
