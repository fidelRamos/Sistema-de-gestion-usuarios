using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class manteRolModulo : Form
    {
        CN_GetData objectCN = new CN_GetData();
        int indexRol;
        int indexModulo;
        public manteRolModulo()
        {
            InitializeComponent();
        }

        private void manteRolModulo_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarComboBoxRol();
            CargarComboBoxOpcMod();
        }

        private void bttRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objectCN.InsertartOpcModDelRol(cbModulos.Text, cbRol.Text);
                MessageBox.Show("Registro insertado");
                CargarModulos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            if (dgvModulos.SelectedRows.Count > 0 && dgvRoles.SelectedRows.Count>0)
            {
                
                DataGridViewRow fila = dgvModulos.SelectedRows[0];
               

                try
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado ?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        objectCN.EliminarOpcModDelRol(indexModulo.ToString(),indexRol.ToString());
                        MessageBox.Show("Registro Eliminado!");
                        CargarModulos();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Para Eliminar un registro primero debe seleccionarlo!");
            }
        }
        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void CargarRoles()
        {
            dgvRoles.DataSource = objectCN.GetDataRoles();
        }
        public void CargarModulos()
        {
            
             dgvModulos.DataSource = objectCN.GetOpcModDelRol(indexRol.ToString());
            
        }
        public void LimpiarCampos()
        {
            cbRol.Text = "";
            cbModulos.Text = "";
            txtModulo.Text = "";
            txtRol.Text = "";
        }

       public void CargarComboBoxRol()
        {
            DataTable myTable = new DataTable();
            myTable = objectCN.GetDataRoles();
            DataColumn columna = myTable.Columns[0];
            foreach (DataRow fila in myTable.Rows)
            {
                cbRol.Items.Add(fila[columna]);
            }
       }
        public void CargarComboBoxOpcMod()
        {
            DataTable myTable = new DataTable();
            myTable = objectCN.GetDataOpcMod();
            DataColumn columna = myTable.Columns[0];
            foreach (DataRow fila in myTable.Rows)
            {
                cbModulos.Items.Add(fila[columna]);
            }
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelect = Int32.Parse(cbRol.Text);
            txtRol.Text = objectCN.GetRol(indiceSelect);
        }

        private void cbModulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelect = Int32.Parse(cbModulos.Text);
            txtModulo.Text = objectCN.GetOpcMod(indiceSelect);
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRol = Convert.ToInt32(dgvRoles.Rows[e.RowIndex].Cells[0].Value);
            //MessageBox.Show(indexRol.ToString());
            CargarModulos();
        }

        private void dgvModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexModulo = Convert.ToInt32(dgvModulos.Rows[e.RowIndex].Cells[0].Value);
            //MessageBox.Show(indexModulo.ToString());
        }
    }
}
