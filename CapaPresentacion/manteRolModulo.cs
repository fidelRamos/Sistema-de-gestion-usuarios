using System;
using System.Collections;
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
    public partial class manteRolModulo : Form
    {
        CN_GetData objectCN = new CN_GetData();

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
                int indiceRol = dgvRoles.CurrentCell.RowIndex + 1;
                DataGridViewRow fila = dgvModulos.SelectedRows[0];
                string valor = fila.Cells[0].Value.ToString();

                try
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado ?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        objectCN.EliminarOpcModDelRol(valor,indiceRol.ToString());
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
            CargarModulos();
        }

        private void CargarRoles()
        {
            dgvRoles.DataSource = objectCN.GetDataRoles();
        }
        public void CargarModulos()
        {
                int indiceSelect = dgvRoles.CurrentCell.RowIndex + 1;
                dgvModulos.DataSource = objectCN.GetOpcModDelRol(indiceSelect.ToString());
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
            int indiceSelect = cbRol.SelectedIndex + 1;
            txtRol.Text = objectCN.GetRol(indiceSelect);
        }

        private void cbModulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelect = cbModulos.SelectedIndex+1;
            txtModulo.Text = objectCN.GetOpcMod(indiceSelect);
        }
    }
}
