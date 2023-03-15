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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manteRolModulo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.dgvModulos = new System.Windows.Forms.DataGridView();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbRegisRolxMod = new System.Windows.Forms.GroupBox();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.bttRegistrar = new System.Windows.Forms.Button();
            this.cbModulos = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
            this.gbRegisRolxMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modulos Asignados del Rol";
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(611, 80);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 25;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(546, 175);
            this.dgvRoles.TabIndex = 2;
            this.dgvRoles.SelectionChanged += new System.EventHandler(this.dgvRoles_SelectionChanged);
            // 
            // dgvModulos
            // 
            this.dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulos.Location = new System.Drawing.Point(616, 303);
            this.dgvModulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvModulos.Name = "dgvModulos";
            this.dgvModulos.RowHeadersWidth = 51;
            this.dgvModulos.RowTemplate.Height = 25;
            this.dgvModulos.Size = new System.Drawing.Size(541, 200);
            this.dgvModulos.TabIndex = 3;
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(616, 511);
            this.bttEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(142, 31);
            this.bttEliminar.TabIndex = 5;
            this.bttEliminar.Text = "Eliminar Modulo";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rol";
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(103, 59);
            this.cbRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(46, 28);
            this.cbRol.TabIndex = 7;
            this.cbRol.SelectedIndexChanged += new System.EventHandler(this.cbRol_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modulos";
            // 
            // gbRegisRolxMod
            // 
            this.gbRegisRolxMod.Controls.Add(this.txtModulo);
            this.gbRegisRolxMod.Controls.Add(this.txtRol);
            this.gbRegisRolxMod.Controls.Add(this.bttRegistrar);
            this.gbRegisRolxMod.Controls.Add(this.cbModulos);
            this.gbRegisRolxMod.Controls.Add(this.cbRol);
            this.gbRegisRolxMod.Controls.Add(this.label4);
            this.gbRegisRolxMod.Controls.Add(this.label3);
            this.gbRegisRolxMod.Location = new System.Drawing.Point(79, 303);
            this.gbRegisRolxMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbRegisRolxMod.Name = "gbRegisRolxMod";
            this.gbRegisRolxMod.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbRegisRolxMod.Size = new System.Drawing.Size(458, 273);
            this.gbRegisRolxMod.TabIndex = 9;
            this.gbRegisRolxMod.TabStop = false;
            this.gbRegisRolxMod.Text = "Registro";
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(160, 123);
            this.txtModulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.ReadOnly = true;
            this.txtModulo.Size = new System.Drawing.Size(257, 27);
            this.txtModulo.TabIndex = 12;
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(157, 59);
            this.txtRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRol.Name = "txtRol";
            this.txtRol.ReadOnly = true;
            this.txtRol.Size = new System.Drawing.Size(260, 27);
            this.txtRol.TabIndex = 11;
            // 
            // bttRegistrar
            // 
            this.bttRegistrar.Location = new System.Drawing.Point(190, 192);
            this.bttRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttRegistrar.Name = "bttRegistrar";
            this.bttRegistrar.Size = new System.Drawing.Size(86, 31);
            this.bttRegistrar.TabIndex = 10;
            this.bttRegistrar.Text = "Guardar";
            this.bttRegistrar.UseVisualStyleBackColor = true;
            this.bttRegistrar.Click += new System.EventHandler(this.bttRegistrar_Click);
            // 
            // cbModulos
            // 
            this.cbModulos.FormattingEnabled = true;
            this.cbModulos.Location = new System.Drawing.Point(103, 123);
            this.cbModulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbModulos.Name = "cbModulos";
            this.cbModulos.Size = new System.Drawing.Size(46, 28);
            this.cbModulos.TabIndex = 9;
            this.cbModulos.SelectedIndexChanged += new System.EventHandler(this.cbModulos_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Modulos_Roles;
            this.pictureBox1.Location = new System.Drawing.Point(120, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // manteRolModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbRegisRolxMod);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.dgvModulos);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "manteRolModulo";
            this.Text = "Mantenimiento de Modulos asignados a Roles";
            this.Load += new System.EventHandler(this.manteRolModulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
            this.gbRegisRolxMod.ResumeLayout(false);
            this.gbRegisRolxMod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvRoles;
        private DataGridView dgvModulos;
        private Button bttEliminar;
        private Label label3;
        private ComboBox cbRol;
        private Label label4;
        private GroupBox gbRegisRolxMod;
        private Button bttRegistrar;
        private ComboBox cbModulos;
        private TextBox txtModulo;
        private TextBox txtRol;
        private PictureBox pictureBox1;
    }
}