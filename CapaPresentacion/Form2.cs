using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
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
        }
        private void CargarProvincias()
        {
            dataGridView1.DataSource = objCapaNegocio.InfoUser(objCapaNegocio.GetDataAlumnos(user, password).Rows[0][0].ToString());
        }
    }
}
