namespace CapaPresentacion
{
    partial class OpcModCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOpcMod = new System.Windows.Forms.DataGridView();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreOPC = new System.Windows.Forms.TextBox();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.cbIDMod = new System.Windows.Forms.ComboBox();
            this.lbNombreObj = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtNombreObj = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(138, 356);
            this.bttGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(86, 31);
            this.bttGuardar.TabIndex = 0;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la Opcion";
            // 
            // dgvOpcMod
            // 
            this.dgvOpcMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpcMod.Location = new System.Drawing.Point(405, 61);
            this.dgvOpcMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOpcMod.Name = "dgvOpcMod";
            this.dgvOpcMod.RowHeadersWidth = 51;
            this.dgvOpcMod.RowTemplate.Height = 25;
            this.dgvOpcMod.Size = new System.Drawing.Size(475, 355);
            this.dgvOpcMod.TabIndex = 2;
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(407, 439);
            this.bttEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(86, 31);
            this.bttEditar.TabIndex = 3;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(521, 439);
            this.bttEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(86, 31);
            this.bttEliminar.TabIndex = 4;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID del Modulo";
            // 
            // txtNombreOPC
            // 
            this.txtNombreOPC.Location = new System.Drawing.Point(193, 80);
            this.txtNombreOPC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreOPC.Name = "txtNombreOPC";
            this.txtNombreOPC.Size = new System.Drawing.Size(172, 27);
            this.txtNombreOPC.TabIndex = 6;
            this.txtNombreOPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreOPC_KeyPress);
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(251, 161);
            this.txtNombreMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.ReadOnly = true;
            this.txtNombreMod.Size = new System.Drawing.Size(114, 27);
            this.txtNombreMod.TabIndex = 7;
            // 
            // cbIDMod
            // 
            this.cbIDMod.FormattingEnabled = true;
            this.cbIDMod.Location = new System.Drawing.Point(193, 161);
            this.cbIDMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbIDMod.Name = "cbIDMod";
            this.cbIDMod.Size = new System.Drawing.Size(51, 28);
            this.cbIDMod.TabIndex = 8;
            this.cbIDMod.SelectedIndexChanged += new System.EventHandler(this.cbIDMod_SelectedIndexChanged);
            // 
            // lbNombreObj
            // 
            this.lbNombreObj.AutoSize = true;
            this.lbNombreObj.Location = new System.Drawing.Point(42, 237);
            this.lbNombreObj.Name = "lbNombreObj";
            this.lbNombreObj.Size = new System.Drawing.Size(112, 20);
            this.lbNombreObj.TabIndex = 9;
            this.lbNombreObj.Text = "Nombre objeto";
            this.lbNombreObj.Visible = false;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(42, 293);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(54, 20);
            this.lbEstado.TabIndex = 10;
            this.lbEstado.Text = "Estado";
            this.lbEstado.Visible = false;
            // 
            // txtNombreObj
            // 
            this.txtNombreObj.Location = new System.Drawing.Point(193, 227);
            this.txtNombreObj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreObj.Name = "txtNombreObj";
            this.txtNombreObj.Size = new System.Drawing.Size(172, 27);
            this.txtNombreObj.TabIndex = 11;
            this.txtNombreObj.Visible = false;
            this.txtNombreObj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreObj_KeyPress);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "A",
            "N"});
            this.cbEstado.Location = new System.Drawing.Point(193, 283);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(79, 28);
            this.cbEstado.TabIndex = 12;
            this.cbEstado.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OpcModCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtNombreObj);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbNombreObj);
            this.Controls.Add(this.cbIDMod);
            this.Controls.Add(this.txtNombreMod);
            this.Controls.Add(this.txtNombreOPC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.dgvOpcMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttGuardar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OpcModCRUD";
            this.Text = "Mantenimiento Opciones de Modulos";
            this.Load += new System.EventHandler(this.OpcModCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttGuardar;
        private Label label1;
        private DataGridView dgvOpcMod;
        private Button bttEditar;
        private Button bttEliminar;
        private Label label2;
        private TextBox txtNombreOPC;
        private TextBox txtNombreMod;
        private ComboBox cbIDMod;
        private Label lbNombreObj;
        private Label lbEstado;
        private TextBox txtNombreObj;
        private ComboBox cbEstado;
        private ErrorProvider errorProvider1;
    }
}