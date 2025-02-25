namespace WFNovo
{
    partial class FrmCadastro
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
            lblTitulo = new Label();
            lblNome = new Label();
            lblEndereco = new Label();
            lblBairro = new Label();
            lblEstados = new Label();
            lblTelefone = new Label();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            txtTelefone = new TextBox();
            cbEstados = new ComboBox();
            txtCelular = new TextBox();
            txtEmail = new TextBox();
            btnGravarCadastro = new Button();
            btnNovoCadastro = new Button();
            lblCelular = new Label();
            lblEmail = new Label();
            btnVerCadastro = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(174, 48);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(253, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Preencha os campos e clique em Gravar Dados";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(82, 97);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(82, 136);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Endereço:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(82, 180);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 3;
            lblBairro.Text = "Bairro:";
            // 
            // lblEstados
            // 
            lblEstados.AutoSize = true;
            lblEstados.Location = new Point(82, 228);
            lblEstados.Name = "lblEstados";
            lblEstados.Size = new Size(50, 15);
            lblEstados.TabIndex = 4;
            lblEstados.Text = "Estados:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(82, 277);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(197, 89);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(190, 23);
            txtNome.TabIndex = 7;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(197, 128);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(190, 23);
            txtEndereco.TabIndex = 8;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(197, 172);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(190, 23);
            txtBairro.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(197, 269);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(190, 23);
            txtTelefone.TabIndex = 10;
            // 
            // cbEstados
            // 
            cbEstados.FormattingEnabled = true;
            cbEstados.Items.AddRange(new object[] { "AC - Acre", "AL - Alagoas", "AP - Amapá", "AM - Amazonas", "BA - Bahia", "CE - Ceará", "DF - Distrito Federal", "ES - Espírito Santo", "GO - Goiás", "MA - Maranhão", "MT - Mato Grosso", "MS - Mato Grosso do Sul", "MG - Minas Gerais", "PA - Pará", "PB - Paraíba", "PR - Paraná", "PE - Pernambuco", "PI - Piauí", "RJ - Rio de Janeiro", "RN - Rio Grande do Norte", "RS - Rio Grande do Sul", "RO - Rondônia", "RR - Roraima", "SC - Santa Catarina", "SP - São Paulo", "SE - Sergipe", "TO - Tocantins" });
            cbEstados.Location = new Point(197, 220);
            cbEstados.Name = "cbEstados";
            cbEstados.Size = new Size(109, 23);
            cbEstados.TabIndex = 11;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(197, 317);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(190, 23);
            txtCelular.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(197, 361);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(190, 23);
            txtEmail.TabIndex = 13;
            // 
            // btnGravarCadastro
            // 
            btnGravarCadastro.Location = new Point(82, 415);
            btnGravarCadastro.Name = "btnGravarCadastro";
            btnGravarCadastro.Size = new Size(109, 23);
            btnGravarCadastro.TabIndex = 14;
            btnGravarCadastro.Text = "Gravar Cadastro";
            btnGravarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.Location = new Point(197, 414);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(109, 23);
            btnNovoCadastro.TabIndex = 15;
            btnNovoCadastro.Text = "Novo Cadastro";
            btnNovoCadastro.UseVisualStyleBackColor = true;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(82, 325);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 16;
            lblCelular.Text = "Celular:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(82, 369);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email:";
            // 
            // btnVerCadastro
            // 
            btnVerCadastro.Location = new Point(312, 415);
            btnVerCadastro.Name = "btnVerCadastro";
            btnVerCadastro.Size = new Size(115, 23);
            btnVerCadastro.TabIndex = 18;
            btnVerCadastro.Text = "Ver Cadastros";
            btnVerCadastro.UseVisualStyleBackColor = true;
            btnVerCadastro.Click += btnVerCadastro_Click;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerCadastro);
            Controls.Add(lblEmail);
            Controls.Add(lblCelular);
            Controls.Add(btnNovoCadastro);
            Controls.Add(btnGravarCadastro);
            Controls.Add(txtEmail);
            Controls.Add(txtCelular);
            Controls.Add(cbEstados);
            Controls.Add(txtTelefone);
            Controls.Add(txtBairro);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(lblEstados);
            Controls.Add(lblBairro);
            Controls.Add(lblEndereco);
            Controls.Add(lblNome);
            Controls.Add(lblTitulo);
            Name = "FrmCadastro";
            Text = "S";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNome;
        private Label lblEndereco;
        private Label lblBairro;
        private Label lblEstados;
        private Label lblTelefone;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtBairro;
        private TextBox txtTelefone;
        private ComboBox cbEstados;
        private TextBox txtCelular;
        private TextBox txtEmail;
        private Button btnGravarCadastro;
        private Button btnNovoCadastro;
        private Label lblCelular;
        private Label lblEmail;
        private Button btnVerCadastro;
    }
}