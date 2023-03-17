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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class UsuariosCRUD : Form
    {
        CN_GetData objectCN = new CN_GetData();
        bool edicion = false;
        int index;
        public UsuariosCRUD()
        {
            InitializeComponent();
        }

        private void UsuariosCRUD_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarRoles();
        }

        //se modifico validacion
        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (edicion == false)
            {
                try
                {
                    objectCN.InsertarUsuario(txtUsername.Text, txtContrasena.Text, CbBxIDRol.Text, txtNombres.Text, txtNumCel.Text, txtDireccDomic.Text, txtCorreo.Text);
                    BorrarMensajeError();
                    if (ValidarCampos())
                    {
                        MessageBox.Show("Ingreso Correcto");
                        CargarUsuarios();
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
                    
                    objectCN.ActualizarUsuario(index.ToString(), txtUsername.Text, txtContrasena.Text, CbBxIDRol.Text, txtNombres.Text, txtNumCel.Text, txtDireccDomic.Text, txtCorreo.Text);
                    MessageBox.Show("Registro Modificado");
                    edicion = false;
                    CargarUsuarios();
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
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                //entro en modo edicion
                edicion = true;

                //Rellenar campos
                int indice = dgvUsuarios.CurrentCell.RowIndex;
                txtUsername.Text = dgvUsuarios.Rows[indice].Cells[1].Value.ToString();
                txtContrasena.Text = dgvUsuarios.Rows[indice].Cells[2].Value.ToString();
                CbBxIDRol.Text = dgvUsuarios.Rows[indice].Cells[3].Value.ToString();

                txtNombres.Text = dgvUsuarios.Rows[indice].Cells[4].Value.ToString();
                txtNumCel.Text = dgvUsuarios.Rows[indice].Cells[5].Value.ToString();
                txtDireccDomic.Text = dgvUsuarios.Rows[indice].Cells[6].Value.ToString();
                txtCorreo.Text = dgvUsuarios.Rows[indice].Cells[7].Value.ToString();
            }
            else
            {
                MessageBox.Show("Para Editar un registro primero debe seleccionarlo!");
            }
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                
                try
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado ?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        objectCN.EliminarUsuario(index.ToString());
                        MessageBox.Show("Registro Eliminado!");
                        CargarUsuarios();

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
        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = objectCN.GetDataUsuarios();
        }
        private void LimpiarCampos()
        {
            txtUsername.Text = "";
            txtContrasena.Text = "";
            txtIDrol.Text = "";
            CbBxIDRol.Text = "";
            txtNombres.Text = "";
            txtNumCel.Text = "";
            txtDireccDomic.Text = "";
            txtCorreo.Text = "";
        }
        private void CargarRoles()
        {
            DataTable myTable = new DataTable();
            myTable = objectCN.GetDataRoles();
            DataColumn columna = myTable.Columns[0];
            foreach (DataRow fila in myTable.Rows)
            {
                CbBxIDRol.Items.Add(fila[columna]);
            }
        }
        private void CbBxIDRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = Int32.Parse(CbBxIDRol.Text);
            txtIDrol.Text = objectCN.GetRol(indice);
        }



        //se agrego validacion
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo caracteres de contraseña permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //

        //se agrego validacion
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo caracteres para nombres permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //

        //se agrego validacion
        private void txtNumCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo caracteres para numero celular permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDireccDomic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo caracteres permitidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //

        //se agrego validacion
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtUsername.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUsername, "Ingresa un nombre de usuario");
            }

            if (txtContrasena.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtContrasena, "Ingresa una contraseña");
            }

            if (txtNombres.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombres, "Ingresa un nombre");
            }

            if (txtNumCel.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNumCel, "Ingresa un numero de telefono");
            }

            if (txtDireccDomic.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDireccDomic, "Ingresa una direccion domiciliaria valida");
            }

            if (txtCorreo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCorreo, "Ingresa un correo electronico");
            }
            return ok;
        }
        //

        //se agrego validacion
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtUsername, "");
            errorProvider1.SetError(txtContrasena, "");
            errorProvider1.SetError(txtNombres, "");
            errorProvider1.SetError(txtNumCel, "");
            errorProvider1.SetError(txtDireccDomic, "");
            errorProvider1.SetError(txtCorreo, "");
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value);
        }
        //

    }

}
