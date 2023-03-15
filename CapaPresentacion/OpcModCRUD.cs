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
            CargarModulos();


        }
        // se modifico validacion
        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (edicion == false)
            {
                try
                {
                    objectCN.InsertarOpcMod(txtNombreOPC.Text, cbIDMod.Text);
                    if (ValidarCampos())
                    {
                        MessageBox.Show("Ingreso Correcto");
                        CargarModulos();
                    }
                    LimpiarCampos();
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
                    int indiceSelect = dgvOpcMod.CurrentCell.RowIndex + 1;
                    objectCN.ActualizarOpcMod(indiceSelect.ToString(), txtNombreOPC.Text, txtNombreObj.Text, cbIDMod.Text, cbEstado.Text);
                    MessageBox.Show("Registro Modificado");
                    edicion = false;
                    lbNombreObj.Visible = false;
                    txtNombreObj.Visible = false;
                    lbEstado.Visible = false;
                    cbEstado.Visible = false;
                    CargarOpcMod();
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
            if (dgvOpcMod.SelectedRows.Count > 0)
            {
                //entro en modo edicion
                edicion = true;
                //muestro estado
                lbNombreObj.Visible = true;
                txtNombreObj.Visible = true;
                lbEstado.Visible = true;
                cbEstado.Visible = true;
                //Rellenar campos
                int indice = dgvOpcMod.CurrentCell.RowIndex;
                txtNombreMod.Text = "";
                cbIDMod.Text = "";
                txtNombreObj.Text = "";
                cbIDMod.Text = "";
            }
            else
            {
                MessageBox.Show("Para Editar un registro primero debe seleccionarlo!");
            }
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            if (dgvOpcMod.SelectedRows.Count > 0)
            {
                int indiceSelect = dgvOpcMod.CurrentCell.RowIndex + 1;
                try
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado ?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        objectCN.EliminarOpcMod(indiceSelect.ToString());
                        MessageBox.Show("Registro Eliminado!");
                        CargarOpcMod();
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

        private void CargarOpcMod()
        {
            dgvOpcMod.DataSource = objectCN.GetDataOpcMod();
        }
        private void LimpiarCampos()
        {
            txtNombreOPC.Text = "";
            cbIDMod.Text = "";
            txtNombreObj.Text = "";
            cbIDMod.Text = "";
            txtNombreMod.Text = "";
        }
        private void CargarModulos()
        {
            DataTable myTable = new DataTable();
            myTable = objectCN.GetDataModulos();
            DataColumn columna = myTable.Columns[0];
            foreach (DataRow fila in myTable.Rows)
            {
                cbIDMod.Items.Add(fila[columna]);
            }
        }

        private void cbIDMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbIDMod.SelectedIndex + 1;
            txtNombreMod.Text = objectCN.GetMod(indice);
        }

        //se agrego validacion
        private void txtNombreOPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo caracteres permitidos para nombres de opciones", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //

        // se agrego validacion
        private void txtNombreObj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo caracteres permitidos para nombres de objetos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //

        //se agrego validacion
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtNombreObj.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreObj, "Ingresa un nombre para la opcion");
            }

            if (txtNombreOPC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreOPC, "Ingresa un nombre para el objeto");
            }

            return ok;
        }
        //

        //se agrego validacion
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNombreOPC, "");
            errorProvider1.SetError(txtNombreObj, "");
        }
        //
    }
}
