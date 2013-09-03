using Chronos.Service.Models;
using Chronos.Service.Services;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos
{
    public partial class FormCadastroProd : Form
    {
        public FormCadastroProd()
        {
            InitializeComponent();
            Random codigo = new Random();
            txtCodigo.Text = Convert.ToString(codigo.Next(1000, 50000));
            txtCodigo.Enabled = false;
        }

        private void AtualizarCbx()
        {
            cbxFabricante.ValueMember = "Id";
            cbxFabricante.DisplayMember = "Fabricante";
            cbxFabricante.DataSource = ProdutoService.ObterLista();
        }

        public ProdutoModel produto;

        private void FormCadastroProd_Load(object sender, EventArgs e)
        {
            AtualizarCbx();
            if (produto != null)
            {
                txtCodigo.Text = produto.Codigo;
                txtCodigoBarras.Text = produto.CodigoBarras;
                txtDescricao.Text = produto.Descricao;
                txtEstoque.Text = Convert.ToString(produto.NumEstoque);
                txtPreco.Text = produto.Preco;
                txtPrecoVenda.Text = produto.PrecoVenda;
                cbxFabricante.Text = produto.Fabricante;
                cbxFornecedor.Text = produto.Fornecedor;
                cbxGrupo.Text = produto.Grupo;
                dtpEntrada.Value = produto.DataEntrada.Date;
                cbxUnidade.Text = produto.Unidade;
                tabPage1.Text = "Alteração";
                this.Text = "chronOS: Produto (Alteração - " + produto.Codigo + " - " + produto.Descricao + ")";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (produto == null)
            {
                produto = new ProdutoModel();
            }
            try
            {
                produto.Codigo = txtCodigo.Text;
                produto.CodigoBarras = txtCodigoBarras.Text;
                produto.Descricao = txtDescricao.Text;
                produto.Fabricante = cbxFabricante.Text;
                produto.Fornecedor = cbxFornecedor.Text;
                produto.Grupo = cbxGrupo.Text;
                produto.DataEntrada = dtpEntrada.Value.Date;
                produto.NumEstoque = Convert.ToInt32(txtEstoque.Text);
                produto.Preco = txtPreco.Text;
                produto.PrecoVenda = txtPrecoVenda.Text;
                produto.Unidade = cbxUnidade.Text;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString(), "chronOS", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            txtPreco.Text = Convert.ToDecimal(txtPreco.Text).ToString("C");
        }

        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            txtPrecoVenda.Text = Convert.ToDecimal(txtPrecoVenda.Text).ToString("C");
        }
    }
}
