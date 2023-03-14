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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(150, 335);
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
            this.label1.Location = new System.Drawing.Point(38, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la Opcion";
            // 
            // dgvOpcMod
            // 
            this.dgvOpcMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpcMod.Location = new System.Drawing.Point(400, 60);
            this.dgvOpcMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOpcMod.Name = "dgvOpcMod";
            this.dgvOpcMod.RowHeadersWidth = 51;
            this.dgvOpcMod.RowTemplate.Height = 25;
            this.dgvOpcMod.Size = new System.Drawing.Size(475, 256);
            this.dgvOpcMod.TabIndex = 2;
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(400, 335);
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
            this.bttEliminar.Location = new System.Drawing.Point(500, 335);
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
            this.label2.Location = new System.Drawing.Point(38, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID del Modulo";
            // 
            // txtNombreOPC
            // 
            this.txtNombreOPC.Location = new System.Drawing.Point(197, 144);
            this.txtNombreOPC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreOPC.Name = "txtNombreOPC";
            this.txtNombreOPC.Size = new System.Drawing.Size(172, 27);
            this.txtNombreOPC.TabIndex = 6;
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(255, 193);
            this.txtNombreMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.ReadOnly = true;
            this.txtNombreMod.Size = new System.Drawing.Size(114, 27);
            this.txtNombreMod.TabIndex = 7;
            // 
            // cbIDMod
            // 
            this.cbIDMod.FormattingEnabled = true;
            this.cbIDMod.Location = new System.Drawing.Point(197, 193);
            this.cbIDMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbIDMod.Name = "cbIDMod";
            this.cbIDMod.Size = new System.Drawing.Size(51, 28);
            this.cbIDMod.TabIndex = 8;
            this.cbIDMod.SelectedIndexChanged += new System.EventHandler(this.cbIDMod_SelectedIndexChanged);
            // 
            // lbNombreObj
            // 
            this.lbNombreObj.AutoSize = true;
            this.lbNombreObj.Location = new System.Drawing.Point(38, 246);
            this.lbNombreObj.Name = "lbNombreObj";
            this.lbNombreObj.Size = new System.Drawing.Size(112, 20);
            this.lbNombreObj.TabIndex = 9;
            this.lbNombreObj.Text = "Nombre objeto";
            this.lbNombreObj.Visible = false;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(38, 296);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(54, 20);
            this.lbEstado.TabIndex = 10;
            this.lbEstado.Text = "Estado";
            this.lbEstado.Visible = false;
            // 
            // txtNombreObj
            // 
            this.txtNombreObj.Location = new System.Drawing.Point(197, 243);
            this.txtNombreObj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreObj.Name = "txtNombreObj";
            this.txtNombreObj.Size = new System.Drawing.Size(172, 27);
            this.txtNombreObj.TabIndex = 11;
            this.txtNombreObj.Visible = false;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "A",
            "N"});
            this.cbEstado.Location = new System.Drawing.Point(197, 293);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(79, 28);
            this.cbEstado.TabIndex = 12;
            this.cbEstado.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.ManteMod;
            this.pictureBox1.Location = new System.Drawing.Point(75, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // OpcModCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 386);
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
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OpcModCRUD";
            this.Text = "Mantenimiento Opciones de Modulos";
            this.Load += new System.EventHandler(this.OpcModCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private PictureBox pictureBox1;
    }
}