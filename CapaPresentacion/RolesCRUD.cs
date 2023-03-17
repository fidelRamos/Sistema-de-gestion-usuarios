using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        int index;
        public RolesCRUD()
        {
            InitializeComponent();
        }

        private void RolesCRUD_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }


        // se modifico validaciones
        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (edicion == false)
            {
                try
                {
                    objectCN.InsertarRol(txtNombreRol.Text);
                    BorrarMensajeError();
                    if (ValidarCampos())
                    {
                        MessageBox.Show("Ingreso Correcto");
                        CargarRoles();
                    }
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
                    
                    objectCN.ActualizarRol(index.ToString(), txtNombreRol.Text, comboBEstado.Text);
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
        //



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
                
                try
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado ?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        objectCN.EliminarRol(index.ToString());
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

        // se agrego validacion
        private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo caracteres de usuario permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //


        //se agrego validacion
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtNombreRol.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreRol, "Ingresa un nombre para el Rol");
            }

            if (comboBEstado.Text == "")
            {
                ok = false;
                errorProvider1.SetError(comboBEstado, "Selecciona una opcion");
            }

            return ok;
        }
        //

        //se agrego validacion
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNombreRol, "");
            errorProvider1.SetError(comboBEstado, "");
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = Convert.ToInt32(dgvRoles.Rows[e.RowIndex].Cells[0].Value);
        }
        //


    }
}
