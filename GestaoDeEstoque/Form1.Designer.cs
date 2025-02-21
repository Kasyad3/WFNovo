namespace GestaoDeEstoque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.dvgProdutos = new System.Windows.Forms.DataGridView();
            this.txtNomeProduto = new System.Windows.Forms.Label();
            this.txtPrecoProduto = new System.Windows.Forms.Label();
            this.txtQuantidadeProduto = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCNPJFornecedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(130, 231);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 3;
            this.txtb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(130, 261);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(127, 179);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(111, 23);
            this.btnCadastrarProduto.TabIndex = 6;
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(127, 302);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(111, 23);
            this.btnCadastrarFornecedor.TabIndex = 7;
            this.btnCadastrarFornecedor.Text = "Cadastrar Forncedor";
            this.btnCadastrarFornecedor.UseVisualStyleBackColor = true;
            // 
            // dvgProdutos
            // 
            this.dvgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProdutos.Location = new System.Drawing.Point(388, 288);
            this.dvgProdutos.Name = "dvgProdutos";
            this.dvgProdutos.Size = new System.Drawing.Size(240, 150);
            this.dvgProdutos.TabIndex = 8;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.AutoSize = true;
            this.txtNomeProduto.Location = new System.Drawing.Point(29, 26);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(95, 13);
            this.txtNomeProduto.TabIndex = 9;
            this.txtNomeProduto.Text = "Nome Do Produto:";
            this.txtNomeProduto.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.AutoSize = true;
            this.txtPrecoProduto.Location = new System.Drawing.Point(26, 77);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(95, 13);
            this.txtPrecoProduto.TabIndex = 10;
            this.txtPrecoProduto.Text = "Preço Do Produto:";
            this.txtPrecoProduto.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.AutoSize = true;
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(14, 116);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(110, 13);
            this.txtQuantidadeProduto.TabIndex = 11;
            this.txtQuantidadeProduto.Text = "Quantida De Produto:";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.AutoSize = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(46, 159);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(64, 13);
            this.cmbFornecedor.TabIndex = 12;
            this.cmbFornecedor.Text = "Fornecedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome Do Produto:";
            // 
            // txtCNPJFornecedor
            // 
            this.txtCNPJFornecedor.AutoSize = true;
            this.txtCNPJFornecedor.Location = new System.Drawing.Point(52, 268);
            this.txtCNPJFornecedor.Name = "txtCNPJFornecedor";
            this.txtCNPJFornecedor.Size = new System.Drawing.Size(37, 13);
            this.txtCNPJFornecedor.TabIndex = 14;
            this.txtCNPJFornecedor.Text = "CNPJ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCNPJFornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.txtQuantidadeProduto);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.dvgProdutos);
            this.Controls.Add(this.btnCadastrarFornecedor);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnCadastrarFornecedor;
        private System.Windows.Forms.DataGridView dvgProdutos;
        private System.Windows.Forms.Label txtNomeProduto;
        private System.Windows.Forms.Label txtPrecoProduto;
        private System.Windows.Forms.Label txtQuantidadeProduto;
        private System.Windows.Forms.Label cmbFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtCNPJFornecedor;
    }
}

