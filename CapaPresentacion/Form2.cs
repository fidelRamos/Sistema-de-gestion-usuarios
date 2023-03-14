using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
        MenuStrip menuStrip = new MenuStrip();
        Dictionary<string, ToolStripMenuItem> moduleMenus = new Dictionary<string, ToolStripMenuItem>();

        private string user;
        private string password;
        CN_GetData objCapaNegocio = new CN_GetData();
        public Form2(string user, string password)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarProvincias();
            SqlDataReader reader= objCapaNegocio.reader(objCapaNegocio.GetDataAlumnos(user, password).Rows[0][3].ToString());
            while (reader.Read())
            {
                string roleName = reader.GetString(0);
                string moduleName = reader.GetString(1);
                string optionName = reader.GetString(2);

                // crear el menú dinámico utilizando los datos obtenidos
                if (!moduleMenus.ContainsKey(optionName))
                {
                    // si no existe, crear un nuevo menú para el módulo
                    ToolStripMenuItem moduleMenu = new ToolStripMenuItem(optionName);
                   
                    moduleMenus.Add(optionName, moduleMenu);
                    menuStrip.Items.Add(moduleMenu);
                }

                // agregar la opción al menú correspondiente
                ToolStripMenuItem optionItem = new ToolStripMenuItem(moduleName);
                optionItem.Tag = roleName;
                optionItem.Click += new EventHandler(item_Click);//agg el evento click a la opcion
                moduleMenus[optionName].DropDownItems.Add(optionItem);
                
            }
            reader.Close();
            this.Controls.Add(menuStrip);


            /*string valor ="";
            List<string> valoresColumna = new List<string>();
            int columnIndex = dataGridView1.Columns["NOMBRE_OPCION"].Index;

            if (dataGridView1.RowCount > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                        valor = Convert.ToString(dataGridView1.Rows[i].Cells[columnIndex].Value);
                        valoresColumna.Add(valor);
                }
                listBox1.DataSource = valoresColumna;
            }
            else
            {
                
                MessageBox.Show("El rol no tiene opc de modulo asignado");
            }*/

        }
        private void CargarProvincias()
        {

            //dataGridView1.DataSource = objCapaNegocio.InfoUser(objCapaNegocio.GetDataAlumnos(user, password).Rows[0][0].ToString());
        }

        private void  item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            
            
            if (item != null) {
                string nombre = item.Text;
                identificarModulo(nombre);
            }
            
        }
        private void identificarModulo(string nombre)
        {
            switch (nombre)
            {

                case "MANTENIMIENTO ROLES":
                    //Salta form de CRUD Rol
                    RolesCRUD formRol = new RolesCRUD();
                    formRol.Show();
                    break;
                case "MANTENIMIENTO USUARIOS":
                    //Salta form de CRUD usuarios
                    UsuariosCRUD formUsuarios = new UsuariosCRUD();
                    formUsuarios.Show();
                    break;
                case "MODULOS DEL SISTEMA": 
                    //Salta form de CRUD sistema
                    ModulosCRUD formModulos = new ModulosCRUD();
                    formModulos.Show();
                    break;
                case "MANTENIMIENTO OPCIONES DE MODULOS"://falta agg al sql
                    //Salta form de Opciones de modulos
                    OpcModCRUD formOpMod = new OpcModCRUD();
                    formOpMod.Show();
                    break;
                case "MANTENIMIENTO MODULOS DE ROLES": //falta agg al sql
                    //Salta form de CRUD sistema
                    manteRolModulo formRolModu = new manteRolModulo();
                    formRolModu.Show();
                    break;

                case "MANTENIMIENTO ESTUDIANTE": //falta agg al sql
                    //Salta form de CRUD Estudiante
                    EstudiantesCRUD formEstudiante = new EstudiantesCRUD();
                    formEstudiante.Show();
                    break;
            }
        }
    }
}
