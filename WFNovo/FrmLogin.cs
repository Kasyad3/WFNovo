namespace WFNovo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtbUserName.Text.Trim();
            string password = txtbPassword.Text.Trim();

            if (username != string.Empty && password != string.Empty)
            {
                FrmCadastro frmCadastro = new FrmCadastro();
                frmCadastro.ShowDialog();
            }

            else
            {
                MessageBox.Show("Os campos não podem estar vazios","Erro"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
