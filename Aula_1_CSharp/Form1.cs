namespace Aula_1_CSharp
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

        private void btnCumprimentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá, Mundo!", "Aula 1 - CSharp");
        }
    }
}
