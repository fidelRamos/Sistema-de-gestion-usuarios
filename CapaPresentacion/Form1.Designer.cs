namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.PB_user = new System.Windows.Forms.PictureBox();
            this.GB_session = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_user)).BeginInit();
            this.GB_session.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(114, 26);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ShortcutsEnabled = false;
            this.textBoxUser.Size = new System.Drawing.Size(125, 27);
            this.textBoxUser.TabIndex = 0;
            this.textBoxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUser_KeyPress);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(114, 78);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.ShortcutsEnabled = false;
            this.textBoxPass.Size = new System.Drawing.Size(125, 27);
            this.textBoxPass.TabIndex = 1;
            this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPass_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(88, 128);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // PB_user
            // 
            this.PB_user.Image = global::CapaPresentacion.Properties.Resources.User_ico;
            this.PB_user.Location = new System.Drawing.Point(147, 12);
            this.PB_user.Name = "PB_user";
            this.PB_user.Size = new System.Drawing.Size(125, 111);
            this.PB_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_user.TabIndex = 5;
            this.PB_user.TabStop = false;
            // 
            // GB_session
            // 
            this.GB_session.Controls.Add(this.textBoxUser);
            this.GB_session.Controls.Add(this.textBoxPass);
            this.GB_session.Controls.Add(this.btnLogin);
            this.GB_session.Controls.Add(this.label1);
            this.GB_session.Controls.Add(this.label2);
            this.GB_session.Location = new System.Drawing.Point(59, 145);
            this.GB_session.Name = "GB_session";
            this.GB_session.Size = new System.Drawing.Size(280, 180);
            this.GB_session.TabIndex = 6;
            this.GB_session.TabStop = false;
            this.GB_session.Text = "Datos de sesion";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 353);
            this.Controls.Add(this.GB_session);
            this.Controls.Add(this.PB_user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inicio de sesion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_user)).EndInit();
            this.GB_session.ResumeLayout(false);
            this.GB_session.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBoxUser;
        private TextBox textBoxPass;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private PictureBox PB_user;
        private GroupBox GB_session;
        private ErrorProvider errorProvider1;
    }
}