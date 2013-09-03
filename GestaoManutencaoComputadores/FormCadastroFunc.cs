using Chronos.Classes;
using Chronos.Service.Models;
using Chronos.Service.Services;
using GestaoManutencaoComputadores.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos
{
    public partial class FormCadastroFunc : Form
    {
        public FormCadastroFunc()
        {
            InitializeComponent();
            Random codigo = new Random();
            txtCodigo.Text = Convert.ToString(codigo.Next(1000, 50000));
            txtCodigo.Enabled = false;
        }

        private void AtualizarCbx()
        {
            cbxCidade.ValueMember = "Id";
            cbxCidade.DisplayMember = "Nome";
            cbxCidade.DataSource = CidadeService.ObterLista();

            cbxEstado.ValueMember = "Id";
            cbxEstado.DisplayMember = "UF";
            cbxEstado.DataSource = EstadoService.ObterLista();

            cbxFuncao.ValueMember = "Id";
            cbxFuncao.DisplayMember = "Funcao";
            cbxFuncao.DataSource = FuncaoService.ObterLista();
        }

        private void cbxEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxCidade.ValueMember = "Id";
            cbxCidade.DisplayMember = "Nome";
            cbxCidade.DataSource = CidadeService.ObterListaPorId(
                Convert.ToInt32(cbxEstado.SelectedValue));
        }

        public FuncionarioModel funcionario;

        private void FormCadastroFunc_Load(object sender, EventArgs e)
        {
            AtualizarCbx();
            if (funcionario != null)
            {
                ckbAtivo.Checked = funcionario.Ativo;
                txtNome.Text = funcionario.Nome;
                txtCodigo.Text = Convert.ToString(funcionario.Codigo);
                txtCpf.Text = funcionario.Cpf;
                txtRg.Text = funcionario.Rg;
                txtTelefone.Text = funcionario.Telefone;
                txtCelular.Text = funcionario.Celular;
                txtCep.Text = funcionario.Cep;
                txtEndereco.Text = funcionario.Endereco;
                txtBairro.Text = funcionario.Bairro;
                cbxCidade.Text = funcionario.Cidade;
                cbxEstado.Text = funcionario.Estado;
                cbxFuncao.SelectedValue = funcionario.Funcao.Id;
                dtpAdmissao.Value = funcionario.DataAdmissao.Date;
                dtpDataCadastro.Value = funcionario.DataCadastro.Date;
                tabPage1.Text = "Alteração";
                this.Text = "chronOS: Funcionário (Alteração - " + Convert.ToString(funcionario.Codigo) + ": " + funcionario.Nome +")";
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (funcionario == null)
            {
                funcionario = new FuncionarioModel();
                funcionario.Funcao = new FuncaoModel();
            }
            try
            {
                funcionario.Nome = txtNome.Text;
                funcionario.Cpf = txtCpf.Text;
                funcionario.Rg = txtRg.Text;
                funcionario.Celular = txtCelular.Text;
                funcionario.Telefone = txtTelefone.Text;
                funcionario.Endereco = txtEndereco.Text;
                funcionario.Codigo = Convert.ToInt32(txtCodigo.Text);
                funcionario.Bairro = txtBairro.Text;
                funcionario.Cep = txtCep.Text;
                funcionario.Cidade = cbxCidade.Text;
                funcionario.Estado = cbxEstado.Text;
                funcionario.Funcao.Id = Convert.ToInt32(cbxFuncao.SelectedValue);
                funcionario.DataAdmissao = dtpAdmissao.Value.Date;
                funcionario.DataCadastro = dtpDataCadastro.Value.Date;
                funcionario.Ativo = ckbAtivo.Checked;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "chronOS", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Existente()
        {
            string cpf = null;
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = Conexao.CaminhoConexao;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Cpf FROM Funcionario ");
            sql.Append("WHERE Cpf = '" + txtCpf.Text + "'");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    cpf = leitor["Cpf"].ToString();
                    if (txtCpf.Text == cpf)
                    {
                        MessageBox.Show("Um funcionário com o mesmo CPF já se encontra cadastrado no sistema", "Chronos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCpf.Clear();
                        txtNome.Clear();
                        txtNome.Focus();
                    }
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            Existente();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtNome.Text = TextBoxCorretor.Corretor(txtNome.Text);
        }

        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            txtEndereco.Text = TextBoxCorretor.Corretor(txtEndereco.Text);
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            txtBairro.Text = TextBoxCorretor.Corretor(txtBairro.Text);
        }
    }
}
