namespace CapaPresentacion
{
    partial class UsuariosCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosCRUD));
            this.bttGuardar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtIDrol = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtNumCel = new System.Windows.Forms.TextBox();
            this.txtDireccDomic = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.CbBxIDRol = new System.Windows.Forms.ComboBox();
            this.GB_datos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.GB_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(146, 450);
            this.bttGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(86, 31);
            this.bttGuardar.TabIndex = 0;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(469, 40);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.Size = new System.Drawing.Size(723, 402);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(469, 450);
            this.bttEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(86, 31);
            this.bttEditar.TabIndex = 2;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(601, 450);
            this.bttEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(86, 31);
            this.bttEliminar.TabIndex = 3;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Direccion Domiciliaria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Correo Electrónico";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(171, 36);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(225, 27);
            this.txtUsername.TabIndex = 11;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(171, 74);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(225, 27);
            this.txtContrasena.TabIndex = 12;
            // 
            // txtIDrol
            // 
            this.txtIDrol.Enabled = false;
            this.txtIDrol.Location = new System.Drawing.Point(282, 113);
            this.txtIDrol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDrol.Name = "txtIDrol";
            this.txtIDrol.Size = new System.Drawing.Size(114, 27);
            this.txtIDrol.TabIndex = 13;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(171, 152);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(225, 27);
            this.txtNombres.TabIndex = 14;
            // 
            // txtNumCel
            // 
            this.txtNumCel.Location = new System.Drawing.Point(171, 190);
            this.txtNumCel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumCel.Name = "txtNumCel";
            this.txtNumCel.Size = new System.Drawing.Size(225, 27);
            this.txtNumCel.TabIndex = 15;
            // 
            // txtDireccDomic
            // 
            this.txtDireccDomic.Location = new System.Drawing.Point(171, 229);
            this.txtDireccDomic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccDomic.Name = "txtDireccDomic";
            this.txtDireccDomic.Size = new System.Drawing.Size(225, 27);
            this.txtDireccDomic.TabIndex = 16;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(171, 268);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(225, 27);
            this.txtCorreo.TabIndex = 17;
            // 
            // CbBxIDRol
            // 
            this.CbBxIDRol.FormattingEnabled = true;
            this.CbBxIDRol.Location = new System.Drawing.Point(171, 113);
            this.CbBxIDRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbBxIDRol.Name = "CbBxIDRol";
            this.CbBxIDRol.Size = new System.Drawing.Size(92, 28);
            this.CbBxIDRol.TabIndex = 18;
            this.CbBxIDRol.SelectedIndexChanged += new System.EventHandler(this.CbBxIDRol_SelectedIndexChanged);
            // 
            // GB_datos
            // 
            this.GB_datos.Controls.Add(this.label1);
            this.GB_datos.Controls.Add(this.CbBxIDRol);
            this.GB_datos.Controls.Add(this.label2);
            this.GB_datos.Controls.Add(this.txtCorreo);
            this.GB_datos.Controls.Add(this.label3);
            this.GB_datos.Controls.Add(this.txtDireccDomic);
            this.GB_datos.Controls.Add(this.label4);
            this.GB_datos.Controls.Add(this.txtNumCel);
            this.GB_datos.Controls.Add(this.label5);
            this.GB_datos.Controls.Add(this.txtNombres);
            this.GB_datos.Controls.Add(this.label6);
            this.GB_datos.Controls.Add(this.txtIDrol);
            this.GB_datos.Controls.Add(this.label7);
            this.GB_datos.Controls.Add(this.txtContrasena);
            this.GB_datos.Controls.Add(this.txtUsername);
            this.GB_datos.Location = new System.Drawing.Point(12, 125);
            this.GB_datos.Name = "GB_datos";
            this.GB_datos.Size = new System.Drawing.Size(428, 317);
            this.GB_datos.TabIndex = 19;
            this.GB_datos.TabStop = false;
            this.GB_datos.Text = "Datos Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.User_ico;
            this.pictureBox1.Location = new System.Drawing.Point(150, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // UsuariosCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GB_datos);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.bttGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UsuariosCRUD";
            this.Text = "Mantenimiento de Usuarios";
            this.Load += new System.EventHandler(this.UsuariosCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.GB_datos.ResumeLayout(false);
            this.GB_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bttGuardar;
        private DataGridView dgvUsuarios;
        private Button bttEditar;
        private Button bttEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUsername;
        private TextBox txtContrasena;
        private TextBox txtIDrol;
        private TextBox txtNombres;
        private TextBox txtNumCel;
        private TextBox txtDireccDomic;
        private TextBox txtCorreo;
        private ComboBox CbBxIDRol;
        private GroupBox GB_datos;
        private PictureBox pictureBox1;
    }
}