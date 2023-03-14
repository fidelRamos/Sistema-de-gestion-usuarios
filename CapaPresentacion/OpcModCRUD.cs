using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class OpcModCRUD : Form
    {
        CN_GetData objectCN = new CN_GetData();
        bool edicion = false;
        public OpcModCRUD()
        {
            InitializeComponent();
        }

        private void OpcModCRUD_Load(object sender, EventArgs e)
        {
            CargarOpcMod();

        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {

        }

        private void bttEditar_Click(object sender, EventArgs e)
        {

        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {

        }

        private void CargarOpcMod()
        {
            dgvOpcMod.DataSource = objectCN.GetDataOpcMod();
        }
        private void LimpiarCampos()
        {
            txtNombreMod.Text = "";
            txtNombreOPC.Text = "";
            cbIDMod.Text = "";
        }
    }
}
