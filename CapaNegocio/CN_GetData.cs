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
        //MODULOS
        public DataTable GetDataModulos()
        {
            DataTable myTable = new DataTable();
            myTable = objectCD.ObtenerModulos();
            return myTable;
        }
        public void InsertarModulo(string nombreMod, string nombreObj)
        {
            objectCD.InsertarModulo(nombreMod, nombreObj);
        }
        public void ActualizarModulo(string idModulo, string nombreMod, string nombreObj, string estado)
        {
            objectCD.ActualizarModulos(int.Parse(idModulo), nombreMod, nombreObj, char.Parse(estado));
        }
        public void EliminarModulo(string idMod)
        {
            objectCD.EliminarModulo(int.Parse(idMod));
        }
        //OPC MODULOS
        public DataTable GetDataOpcMod()
        {
            DataTable myTable = new DataTable();
            myTable = objectCD.ObtenerOpcModulos();
            return myTable;
        }
        public void InsertarOpcMod(string nombreOpcion, string idModulo)
        {
            objectCD.InsertarOpcMod(nombreOpcion, idModulo);
        }
        public void ActualizarOpcMod(string id_opc_mod, string nombreOpcion, string nombre_Objeto, string idModulo, string estado)
        {
            objectCD.ActualizarOpcMod(int.Parse(id_opc_mod), nombreOpcion, nombre_Objeto, int.Parse(idModulo), char.Parse(estado));
        }
        public void EliminarOpcMod(string id_opc_mod)
        {
            objectCD.EliminarOpcMod(int.Parse(id_opc_mod));
        }
        public string GetMod(int idRol)
        {
            string modbuscado = null;
            DataTable myTable = new DataTable();
            myTable = objectCD.ObtenerModulos();
            foreach (DataRow row in myTable.Rows)
            {
                if ((int)row[0]== idRol)
                {
                    modbuscado = row[1].ToString();
                    break;
                }
            }

            return modbuscado;
        }

        //mod X rol
        public DataTable GetOpcModDelRol(string idRol)
        {
            DataTable myTable = new DataTable();
            myTable = objectCD.obtOpcModDelRol(int.Parse(idRol));
            return myTable;
        }
        public void EliminarOpcModDelRol(string idOpcMod, string idRol)
        {
            objectCD.EliminarOpcModDelRol(int.Parse(idOpcMod), int.Parse(idRol));
        }
        public void InsertartOpcModDelRol(string idModRol, string idRol)
        {
            objectCD.InsertartOpcModDelRol(int.Parse(idModRol), int.Parse(idRol));
        }
        public string GetOpcMod(int idRol)
        {
            string OpcModBuscado= null;
            DataTable myTable = new DataTable();
            myTable = objectCD.ObtenerOpcModulos();
            foreach (DataRow row in myTable.Rows)
            {
                if ((int)row[0] == idRol)
                {
                    OpcModBuscado = row[1].ToString();
                    break;
                }
            }

            return OpcModBuscado;
        }
    }
}
