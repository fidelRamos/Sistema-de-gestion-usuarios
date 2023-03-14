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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcMod)).BeginInit();
            this.SuspendLayout();
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(121, 267);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttGuardar.TabIndex = 0;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la Opcion";
            // 
            // dgvOpcMod
            // 
            this.dgvOpcMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpcMod.Location = new System.Drawing.Point(354, 46);
            this.dgvOpcMod.Name = "dgvOpcMod";
            this.dgvOpcMod.RowTemplate.Height = 25;
            this.dgvOpcMod.Size = new System.Drawing.Size(416, 266);
            this.dgvOpcMod.TabIndex = 2;
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(356, 329);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(75, 23);
            this.bttEditar.TabIndex = 3;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(456, 329);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttEliminar.TabIndex = 4;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID del Modulo";
            // 
            // txtNombreOPC
            // 
            this.txtNombreOPC.Location = new System.Drawing.Point(169, 60);
            this.txtNombreOPC.Name = "txtNombreOPC";
            this.txtNombreOPC.Size = new System.Drawing.Size(151, 23);
            this.txtNombreOPC.TabIndex = 6;
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(220, 121);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.ReadOnly = true;
            this.txtNombreMod.Size = new System.Drawing.Size(100, 23);
            this.txtNombreMod.TabIndex = 7;
            // 
            // cbIDMod
            // 
            this.cbIDMod.FormattingEnabled = true;
            this.cbIDMod.Location = new System.Drawing.Point(169, 121);
            this.cbIDMod.Name = "cbIDMod";
            this.cbIDMod.Size = new System.Drawing.Size(45, 23);
            this.cbIDMod.TabIndex = 8;
            this.cbIDMod.SelectedIndexChanged += new System.EventHandler(this.cbIDMod_SelectedIndexChanged);
            // 
            // lbNombreObj
            // 
            this.lbNombreObj.AutoSize = true;
            this.lbNombreObj.Location = new System.Drawing.Point(37, 178);
            this.lbNombreObj.Name = "lbNombreObj";
            this.lbNombreObj.Size = new System.Drawing.Size(88, 15);
            this.lbNombreObj.TabIndex = 9;
            this.lbNombreObj.Text = "Nombre objeto";
            this.lbNombreObj.Visible = false;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(37, 220);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(42, 15);
            this.lbEstado.TabIndex = 10;
            this.lbEstado.Text = "Estado";
            this.lbEstado.Visible = false;
            // 
            // txtNombreObj
            // 
            this.txtNombreObj.Location = new System.Drawing.Point(169, 170);
            this.txtNombreObj.Name = "txtNombreObj";
            this.txtNombreObj.Size = new System.Drawing.Size(151, 23);
            this.txtNombreObj.TabIndex = 11;
            this.txtNombreObj.Visible = false;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "A",
            "N"});
            this.cbEstado.Location = new System.Drawing.Point(169, 212);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(70, 23);
            this.cbEstado.TabIndex = 12;
            this.cbEstado.Visible = false;
            // 
            // OpcModCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "OpcModCRUD";
            this.Text = "Mantenimiento Opciones de Modulos";
            this.Load += new System.EventHandler(this.OpcModCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcMod)).EndInit();
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
    }
}