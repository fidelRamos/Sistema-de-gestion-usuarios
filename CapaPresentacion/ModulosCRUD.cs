﻿using System;
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
    public partial class ModulosCRUD : Form
    {
        CN_GetData objectCN = new CN_GetData();
        bool edicion = false;
        int index;
        public ModulosCRUD()
        {
            InitializeComponent();
        }

        private void ModulosCRUD_Load(object sender, EventArgs e)
        {
            CargarModulos();
        }

        // se altero validacion
        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (edicion == false)
            {
                try
                {
                    objectCN.InsertarModulo(txtNombreMod.Text, txtNombreObj.Text);
                    BorrarMensajeError();
                    if (ValidarCampos())
                    {
                        MessageBox.Show("Ingreso Correcto");
                        CargarModulos();
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
                    
                    objectCN.ActualizarModulo(index.ToString(), txtNombreMod.Text, txtNombreObj.Text, cbEstado.Text);
                    MessageBox.Show("Registro Modificado");
                    edicion = false;
                    lbEstado.Visible = false;
                    cbEstado.Visible = false;
                    CargarModulos();
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
            if (dgvModulos.SelectedRows.Count > 0)
            {
                //entro en modo edicion
                edicion = true;
                //muestro estado
                lbEstado.Visible = true;
                cbEstado.Visible = true;
                //Rellenar campos
                int indice = dgvModulos.CurrentCell.RowIndex;
                txtNombreMod.Text= dgvModulos.Rows[indice].Cells[1].Value.ToString();
                txtNombreObj.Text = dgvModulos.Rows[indice].Cells[2].Value.ToString();
                cbEstado.Text = dgvModulos.Rows[indice].Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Para Editar un registro primero debe seleccionarlo!");
            }
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            if (dgvModulos.SelectedRows.Count > 0)
            {
                
                try
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado ?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        objectCN.EliminarModulo(index.ToString());
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

        public void CargarModulos()
        {
            dgvModulos.DataSource = objectCN.GetDataModulos();
        }
        public void LimpiarCampos()
        {
            txtNombreMod.Text = "";
            txtNombreObj.Text = "";
            cbEstado.Text = "";
        }

        //se agrego validacion
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtNombreMod.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreMod, "Ingresa un nombre para el modulo");
            }

            if (txtNombreObj.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreObj, "Ingresa un nombre para el objeto");
            }

            return ok;
        }

        //se agrego validacion
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNombreMod, "");
            errorProvider1.SetError(txtNombreObj, "");
        }

        private void dgvModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = Convert.ToInt32(dgvModulos.Rows[e.RowIndex].Cells[0].Value);
        }
        //
    }
}
