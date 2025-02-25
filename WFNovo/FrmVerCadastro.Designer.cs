namespace WFNovo
{
    partial class FrmVerCadastro
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
            lblEmail = new Label();
            lblCelular = new Label();
            lblTelefone = new Label();
            lblEstados = new Label();
            lblBairro = new Label();
            lblEndereco = new Label();
            lblNome = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(228, 327);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "Email:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(228, 283);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 24;
            lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(228, 235);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 23;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEstados
            // 
            lblEstados.AutoSize = true;
            lblEstados.Location = new Point(228, 186);
            lblEstados.Name = "lblEstados";
            lblEstados.Size = new Size(50, 15);
            lblEstados.TabIndex = 22;
            lblEstados.Text = "Estados:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(228, 138);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 21;
            lblBairro.Text = "Bairro:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(228, 94);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 20;
            lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(228, 55);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 19;
            lblNome.Text = "Nome:";
            // 
            // FrmVerCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmail);
            Controls.Add(lblCelular);
            Controls.Add(lblTelefone);
            Controls.Add(lblEstados);
            Controls.Add(lblBairro);
            Controls.Add(lblEndereco);
            Controls.Add(lblNome);
            Name = "FrmVerCadastro";
            Text = "FrmVerCadastro";
            Load += FrmVerCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblCelular;
        private Label lblTelefone;
        private Label lblEstados;
        private Label lblBairro;
        private Label lblEndereco;
        private Label lblNome;
    }
}