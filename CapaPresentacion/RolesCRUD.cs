using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class RolesCRUD : Form
    {
        CN_GetData objectCN = new CN_GetData();
        bool edicion = false;
        public RolesCRUD()
        {
            InitializeComponent();
        }

        private void RolesCRUD_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

       

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (edicion == false)
            {
                try
                {
                    objectCN.InsertarRol(txtNombreRol.Text);
                    MessageBox.Show("Registro insertado");
                    CargarRoles();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (edicion == true)
            {
                try
                {
                    int indiceSelect = dgvRoles.CurrentCell.RowIndex + 1;
                    objectCN.ActualizarRol(indiceSelect.ToString(),txtNombreRol.Text,comboBEstado.Text);
                    MessageBox.Show("Registro Modificado");
                    edicion = false;
                    CargarRoles();
                    LimpiarCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                //entro en modo edicion
                edicion = true;

                //Rellenar campos
                int indice = dgvRoles.CurrentCell.RowIndex;
                txtNombreRol.Text = dgvRoles.Rows[indice].Cells[1].Value.ToString();
                comboBEstado.Text = dgvRoles.Rows[indice].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Para Editar un registro primero debe seleccionarlo!");
            }
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                int indiceSelect = dgvRoles.CurrentCell.RowIndex+1;
                try
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado ?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        objectCN.EliminarRol(indiceSelect.ToString());
                        MessageBox.Show("Registro Eliminado!");
                        CargarRoles();

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

        private void CargarRoles()
        {
            dgvRoles.DataSource = objectCN.GetDataRoles();
        }
        private void LimpiarCampos()
        {
            txtNombreRol.Text = "";
            comboBEstado.Text = "";
        }
    }
}
