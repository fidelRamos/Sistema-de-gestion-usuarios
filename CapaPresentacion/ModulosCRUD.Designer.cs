namespace CapaPresentacion
{
    partial class ModulosCRUD
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
            this.dgvModulos = new System.Windows.Forms.DataGridView();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.lbNombreMod = new System.Windows.Forms.Label();
            this.lbNombrObj = new System.Windows.Forms.Label();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.txtNombreObj = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
            this.SuspendLayout();
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(106, 268);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttGuardar.TabIndex = 0;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // dgvModulos
            // 
            this.dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulos.Location = new System.Drawing.Point(317, 55);
            this.dgvModulos.Name = "dgvModulos";
            this.dgvModulos.RowTemplate.Height = 25;
            this.dgvModulos.Size = new System.Drawing.Size(441, 303);
            this.dgvModulos.TabIndex = 1;
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(317, 369);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(75, 23);
            this.bttEditar.TabIndex = 2;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(405, 369);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttEliminar.TabIndex = 3;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // lbNombreMod
            // 
            this.lbNombreMod.AutoSize = true;
            this.lbNombreMod.Location = new System.Drawing.Point(44, 125);
            this.lbNombreMod.Name = "lbNombreMod";
            this.lbNombreMod.Size = new System.Drawing.Size(96, 15);
            this.lbNombreMod.TabIndex = 4;
            this.lbNombreMod.Text = "Nombre Modulo";
            // 
            // lbNombrObj
            // 
            this.lbNombrObj.AutoSize = true;
            this.lbNombrObj.Location = new System.Drawing.Point(44, 176);
            this.lbNombrObj.Name = "lbNombrObj";
            this.lbNombrObj.Size = new System.Drawing.Size(90, 15);
            this.lbNombrObj.TabIndex = 5;
            this.lbNombrObj.Text = "Nombre Objeto";
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(156, 117);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(100, 23);
            this.txtNombreMod.TabIndex = 6;
            // 
            // txtNombreObj
            // 
            this.txtNombreObj.Location = new System.Drawing.Point(156, 168);
            this.txtNombreObj.Name = "txtNombreObj";
            this.txtNombreObj.Size = new System.Drawing.Size(100, 23);
            this.txtNombreObj.TabIndex = 7;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(44, 220);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(42, 15);
            this.lbEstado.TabIndex = 8;
            this.lbEstado.Text = "Estado";
            this.lbEstado.Visible = false;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "A",
            "N"});
            this.cbEstado.Location = new System.Drawing.Point(156, 212);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(97, 23);
            this.cbEstado.TabIndex = 9;
            this.cbEstado.Visible = false;
            // 
            // ModulosCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.txtNombreObj);
            this.Controls.Add(this.txtNombreMod);
            this.Controls.Add(this.lbNombrObj);
            this.Controls.Add(this.lbNombreMod);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.dgvModulos);
            this.Controls.Add(this.bttGuardar);
            this.Name = "ModulosCRUD";
            this.Text = "ModulosCRUD";
            this.Load += new System.EventHandler(this.ModulosCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttGuardar;
        private DataGridView dgvModulos;
        private Button bttEditar;
        private Button bttEliminar;
        private Label lbNombreMod;
        private Label lbNombrObj;
        private TextBox txtNombreMod;
        private TextBox txtNombreObj;
        private Label lbEstado;
        private ComboBox cbEstado;
    }
}