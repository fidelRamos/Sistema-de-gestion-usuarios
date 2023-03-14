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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class UsuariosCRUD : Form
    {
        CN_GetData objectCN = new CN_GetData();
        bool edicion = false;

        public UsuariosCRUD()
        {
            InitializeComponent();
        }

        private void UsuariosCRUD_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarRoles();
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (edicion == false)
            {
                try
                {
                    objectCN.InsertarUsuario(txtUsername.Text, txtContrasena.Text, CbBxIDRol.Text, txtNombres.Text, txtNumCel.Text, txtDireccDomic.Text, txtCorreo.Text);
                    MessageBox.Show("Registro insertado");
                    CargarUsuarios();
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
                    int indiceSelect = dgvUsuarios.CurrentCell.RowIndex + 1;
                    objectCN.ActualizarUsuario(indiceSelect.ToString(), txtUsername.Text, txtContrasena.Text, CbBxIDRol.Text, txtNombres.Text, txtNumCel.Text, txtDireccDomic.Text, txtCorreo.Text);
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
                int indiceSelect = dgvUsuarios.CurrentCell.RowIndex + 1;
                try
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado ?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        objectCN.EliminarUsuario(indiceSelect.ToString());
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
            int indice = CbBxIDRol.SelectedIndex+1;
            txtIDrol.Text = objectCN.GetRol(indice);
        }
        
    }
    
}
