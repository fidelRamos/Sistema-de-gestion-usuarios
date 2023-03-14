namespace CapaPresentacion
{
    partial class manteRolModulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.dgvModulos = new System.Windows.Forms.DataGridView();
            this.bttAggNewMod = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbModulos = new System.Windows.Forms.ComboBox();
            this.bttRegistrar = new System.Windows.Forms.Button();
            this.bttAsignacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modulos Asignados del Rol";
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(26, 58);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowTemplate.Height = 25;
            this.dgvRoles.Size = new System.Drawing.Size(519, 131);
            this.dgvRoles.TabIndex = 2;
            // 
            // dgvModulos
            // 
            this.dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulos.Location = new System.Drawing.Point(31, 225);
            this.dgvModulos.Name = "dgvModulos";
            this.dgvModulos.RowTemplate.Height = 25;
            this.dgvModulos.Size = new System.Drawing.Size(514, 150);
            this.dgvModulos.TabIndex = 3;
            // 
            // bttAggNewMod
            // 
            this.bttAggNewMod.Location = new System.Drawing.Point(605, 58);
            this.bttAggNewMod.Name = "bttAggNewMod";
            this.bttAggNewMod.Size = new System.Drawing.Size(183, 23);
            this.bttAggNewMod.TabIndex = 4;
            this.bttAggNewMod.Text = "Agregar nuevo Modulos";
            this.bttAggNewMod.UseVisualStyleBackColor = true;
            this.bttAggNewMod.Click += new System.EventHandler(this.bttAggNewMod_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(31, 381);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(124, 23);
            this.bttEliminar.TabIndex = 5;
            this.bttEliminar.Text = "Eliminar Modulo";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rol";
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(90, 44);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(134, 23);
            this.cbRol.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modulos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttRegistrar);
            this.groupBox1.Controls.Add(this.cbModulos);
            this.groupBox1.Controls.Add(this.cbRol);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(605, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 211);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            this.groupBox1.Visible = false;
            // 
            // cbModulos
            // 
            this.cbModulos.FormattingEnabled = true;
            this.cbModulos.Location = new System.Drawing.Point(90, 92);
            this.cbModulos.Name = "cbModulos";
            this.cbModulos.Size = new System.Drawing.Size(134, 23);
            this.cbModulos.TabIndex = 9;
            // 
            // bttRegistrar
            // 
            this.bttRegistrar.Location = new System.Drawing.Point(90, 168);
            this.bttRegistrar.Name = "bttRegistrar";
            this.bttRegistrar.Size = new System.Drawing.Size(75, 23);
            this.bttRegistrar.TabIndex = 10;
            this.bttRegistrar.Text = "Registrar";
            this.bttRegistrar.UseVisualStyleBackColor = true;
            this.bttRegistrar.Click += new System.EventHandler(this.bttRegistrar_Click);
            // 
            // bttAsignacion
            // 
            this.bttAsignacion.Location = new System.Drawing.Point(173, 381);
            this.bttAsignacion.Name = "bttAsignacion";
            this.bttAsignacion.Size = new System.Drawing.Size(127, 23);
            this.bttAsignacion.TabIndex = 10;
            this.bttAsignacion.Text = "Editar Asignación";
            this.bttAsignacion.UseVisualStyleBackColor = true;
            this.bttAsignacion.Click += new System.EventHandler(this.bttAsignacion_Click);
            // 
            // manteRolModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.bttAsignacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttAggNewMod);
            this.Controls.Add(this.dgvModulos);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "manteRolModulo";
            this.Text = "Mantenimiento de Modulos asignados a Roles";
            this.Load += new System.EventHandler(this.manteRolModulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvRoles;
        private DataGridView dgvModulos;
        private Button bttAggNewMod;
        private Button bttEliminar;
        private Label label3;
        private ComboBox cbRol;
        private Label label4;
        private GroupBox groupBox1;
        private Button bttRegistrar;
        private ComboBox cbModulos;
        private Button bttAsignacion;
    }
}