namespace BarbershopManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            FormCriarConta formCriarConta = new FormCriarConta();
            formCriarConta.ShowDialog();

        }
    }
}
