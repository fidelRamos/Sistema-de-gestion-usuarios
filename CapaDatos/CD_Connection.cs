using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Connection
    {
        static private LocalVariable local = new LocalVariable();
        private SqlConnection DB_Connection = new SqlConnection(local.Connection);

        public SqlConnection OpenConnection()
        {
            if (DB_Connection.State == ConnectionState.Closed)
            {
                DB_Connection.Open();
            }
            return DB_Connection;
        }
        public SqlConnection CloseConnection()
        {
            if (DB_Connection.State == ConnectionState.Open)
            {
                DB_Connection.Close();
            }
            return DB_Connection;
        }
    }
}
