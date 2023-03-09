using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
