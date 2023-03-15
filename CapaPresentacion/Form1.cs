using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // en este btnLogin_Click se hizo un cambio de validacion 
        private void btnLogin_Click(object sender, EventArgs e)  
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {
              MessageBox.Show("Inicio de Sesión Correcto");
            }
            Form2 newform = new Form2(textBoxUser.Text, textBoxPass.Text);
            this.Hide();
            newform.Show();
        }
        //

        // se agrego un cambio de validacion 
        private bool ValidarCampos()
        {
            bool ok = true;

            if (textBoxUser.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBoxUser, "Ingresa un usuario");
            }

            if (textBoxPass.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBoxPass, "Ingresa tu contraseña");
            }

            return ok;
        }
        //

        // se agrego un cambio de validacion
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(textBoxUser, "");
            errorProvider1.SetError(textBoxPass, "");
        }
        //

        // se agrego un campo de validacion
        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo caracteres de usuario permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //

        // se agrego un campo de validacion
        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo caracteres de contraseña permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //
    }
}