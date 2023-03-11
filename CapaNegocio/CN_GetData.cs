using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_GetData
    {
        public CD_GetData objectCD = new CD_GetData();
        public DataTable GetDataAlumnos(string p_user, string p_pass)
        {
            DataTable myTable = new DataTable();
            myTable = objectCD.ObtenerAlumnos(p_user,p_pass);
            return myTable;
        }
        public DataTable InfoUser(string p_user)
        {
            DataTable myTable = new DataTable();
            myTable = objectCD.InfoUser(Int32.Parse(p_user));
            return myTable;
        }
        public SqlDataReader reader(string p_user)
        {
            SqlDataReader reader = objectCD.reader(Int32.Parse(p_user));
           
            return reader;
        }
    }
}
