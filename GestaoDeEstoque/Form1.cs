using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeEstoque
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

        public class Produto
        {
            public string Nome { get; set; }
            public double Preco { get; set; }
            public int Quantidade { get; set; }
            public string Fornecedor { get; set; }

            public Produto(string nome, double preco, int quantidade, string fornecedor)
            {
                Nome = nome;
                Preco = preco;
                Quantidade = quantidade;
                Fornecedor = fornecedor;
            }
        }

        public class Fornecedor
        {
            public string Nome { get; set; }
            public string CNPJ { get; set; }

            public Fornecedor(string nome, string cnpj)
            {
                Nome = nome;
                CNPJ = cnpj;
            }
        }

        public partial class MainForm : Form
        {
            // Listas para armazenar produtos e fornecedores
            private List<Produto> produtos = new List<Produto>();
            private List<Fornecedor> fornecedores = new List<Fornecedor>();

            public MainForm()
            {
                InitializeComponent();
            }

            private void btnCadastrarProduto_Click(object sender, EventArgs e)
            {
                string nomeProduto = txtNomeProduto.Text;
                double precoProduto = Convert.ToDouble(txtPrecoProduto.Text);
                int quantidadeProduto = Convert.ToInt32(txtQuantidadeProduto.Text);
                string fornecedorProduto = cmbFornecedor.SelectedItem.ToString();

                Produto novoProduto = new Produto(nomeProduto, precoProduto, quantidadeProduto, fornecedorProduto);
                produtos.Add(novoProduto);

                MessageBox.Show("Produto cadastrado com sucesso!");
                AtualizarListaProdutos();
            }

            private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
            {
                string nomeFornecedor = txtNomeFornecedor.Text;
                string cnpjFornecedor = txtCNPJFornecedor.Text;

                Fornecedor novoFornecedor = new Fornecedor(nomeFornecedor, cnpjFornecedor);
                fornecedores.Add(novoFornecedor);

                // Atualiza o ComboBox de fornecedores
                cmbFornecedor.Items.Add(nomeFornecedor);

                MessageBox.Show("Fornecedor cadastrado com sucesso!");
            }

            private void AtualizarListaProdutos()
            {
                // Atualiza o DataGridView com a lista de produtos
                dgvProdutos.Rows.Clear();
                foreach (var produto in produtos)
                {
                    dgvProdutos.Rows.Add(produto.Nome, produto.Preco, produto.Quantidade, produto.Fornecedor);
                }
            }

            private void MainForm_Load(object sender, EventArgs e)
            {
                // Adiciona fornecedores no ComboBox no carregamento do formulário
                foreach (var fornecedor in fornecedores)
                {
                    cmbFornecedor.Items.Add(fornecedor.Nome);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
