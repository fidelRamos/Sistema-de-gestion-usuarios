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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModulosCRUD));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(121, 285);
            this.bttGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(86, 31);
            this.bttGuardar.TabIndex = 0;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // dgvModulos
            // 
            this.dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulos.Location = new System.Drawing.Point(362, 33);
            this.dgvModulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvModulos.Name = "dgvModulos";
            this.dgvModulos.RowHeadersWidth = 51;
            this.dgvModulos.RowTemplate.Height = 25;
            this.dgvModulos.Size = new System.Drawing.Size(504, 234);
            this.dgvModulos.TabIndex = 1;
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(362, 285);
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
            this.bttEliminar.Location = new System.Drawing.Point(463, 285);
            this.bttEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(86, 31);
            this.bttEliminar.TabIndex = 3;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // lbNombreMod
            // 
            this.lbNombreMod.AutoSize = true;
            this.lbNombreMod.Location = new System.Drawing.Point(44, 140);
            this.lbNombreMod.Name = "lbNombreMod";
            this.lbNombreMod.Size = new System.Drawing.Size(120, 20);
            this.lbNombreMod.TabIndex = 4;
            this.lbNombreMod.Text = "Nombre Modulo";
            // 
            // lbNombrObj
            // 
            this.lbNombrObj.AutoSize = true;
            this.lbNombrObj.Location = new System.Drawing.Point(44, 190);
            this.lbNombrObj.Name = "lbNombrObj";
            this.lbNombrObj.Size = new System.Drawing.Size(114, 20);
            this.lbNombrObj.TabIndex = 5;
            this.lbNombrObj.Text = "Nombre Objeto";
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(170, 137);
            this.txtNombreMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(114, 27);
            this.txtNombreMod.TabIndex = 6;
            // 
            // txtNombreObj
            // 
            this.txtNombreObj.Location = new System.Drawing.Point(170, 183);
            this.txtNombreObj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreObj.Name = "txtNombreObj";
            this.txtNombreObj.Size = new System.Drawing.Size(114, 27);
            this.txtNombreObj.TabIndex = 7;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(44, 240);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(54, 20);
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
            this.cbEstado.Location = new System.Drawing.Point(170, 237);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(114, 28);
            this.cbEstado.TabIndex = 9;
            this.cbEstado.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Modulos;
            this.pictureBox1.Location = new System.Drawing.Point(99, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ModulosCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 338);
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
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModulosCRUD";
            this.Text = "ModulosCRUD";
            this.Load += new System.EventHandler(this.ModulosCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
    }
}