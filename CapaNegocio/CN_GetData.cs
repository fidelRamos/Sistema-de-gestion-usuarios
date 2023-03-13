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

        //Roles
        public DataTable GetDataRoles()
        {
            DataTable myTable = new DataTable();
            myTable = objectCD.ObtenerRoles();
            return myTable;
        }
        public string GetRol(int idRol)
        {
            string rolbuscado=null;
            DataTable myTable = new DataTable();
            myTable = objectCD.ObtenerRoles();
            foreach (DataRow row in myTable.Rows)
            {
                if ((int)row[0] == idRol)
                {
                    rolbuscado = row[1].ToString();
                    break; 
                }
            }

            return rolbuscado;
        }
        public void InsertarRol(string nombreRol)
        {
            objectCD.InsertarRol(nombreRol);
        }
        public void ActualizarRol(string idRol, string nombreRol, string estado)
        {
            objectCD.ActualizarRol(int.Parse(idRol),nombreRol,char.Parse(estado));
        }
        public void EliminarRol(string idRol)
        {
            objectCD.EliminarRol(int.Parse(idRol));        
        }
        
        //Usuarios
        public DataTable GetDataUsuarios()
        {
            DataTable myTable = new DataTable();
            myTable = objectCD.ObtenerUsuarios();
            return myTable;
        }
        public void InsertarUsuario(string username, string clave, string idrol, string nombres, string telefono, string dirDomic, string correo)
        {
            objectCD.InsertarUsuario(username, clave, int.Parse(idrol), nombres, telefono, dirDomic, correo);
        }
        public void ActualizarUsuario(string idUsuario, string username, string clave, string idrol, string nombres, string telefono, string dirDomic, string correo)
        {
            objectCD.ActualizarUser(int.Parse(idUsuario),username, clave, int.Parse(idrol), nombres, telefono, dirDomic, correo);
        }
        public void EliminarUsuario(string idUser)
        {
            objectCD.EliminarUser(int.Parse(idUser));
        }
    }
}
