using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
    }
}
