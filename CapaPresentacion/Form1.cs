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

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2(textBoxUser.Text, textBoxPass.Text);
            this.Hide();
            newform.Show();
           

        }
    }
}