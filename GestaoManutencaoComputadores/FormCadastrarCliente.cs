using Chronos.Classes;
using Chronos.Service.Services;
using GestaoManutencaoComputadores.Service;
using GestaoManutencaoComputadores.Service.Models;
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

namespace GestaoManutencaoComputadores
{
    public partial class FormCadastrarCliente : Form
    {
        public FormCadastrarCliente()
        {
            InitializeComponent();
        }

        private void AtualizarCbx()
        {
            cbxCidade.ValueMember = "Id";
            cbxCidade.DisplayMember = "Nome";
            cbxCidade.DataSource = CidadeService.ObterLista();

            cbxEstado.ValueMember = "Id";
            cbxEstado.DisplayMember = "UF";
            cbxEstado.DataSource = EstadoService.ObterLista();
        }

        public ClienteModel cliente;

        private void FormCadastrarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarCbx();
                if (cliente != null)
                {
                    txtNome.Text = cliente.Nome;
                    txtEmail.Text = cliente.Email;
                    txtEndereco.Text = cliente.Endereco;
                    txtBairro.Text = cliente.Bairro;
                    txtCpf.Text = cliente.Cpf;
                    txtRg.Text = cliente.Rg;
                    txtCelular.Text = cliente.Celular;
                    txtCep.Text = cliente.Cep;
                    cbxCidade.Text = cliente.Cidade;
                    cbxEstado.Text = cliente.Estado;
                    txtTelefone.Text = cliente.Telefone;
                    dtpDataCadastro.Value = cliente.DataCadastro.Date;
                    tabPage1.Text = "Alteração";
                    this.Text = "chronOS: Cliente (Alteração - " +cliente.Nome+")";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "chronOS", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
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
            sql.Append("SELECT Cpf FROM Cliente WHERE Cpf = '" + txtCpf.Text +"'");
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
                        MessageBox.Show("Um cliente com o mesmo CPF já se encontra cadastrado no sistema", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void cbxEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxCidade.ValueMember = "Id";
            cbxCidade.DisplayMember = "Nome";
            cbxCidade.DataSource = CidadeService.ObterListaPorId(
                Convert.ToInt32(cbxEstado.SelectedValue));
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                cliente = new ClienteModel();
            }
            try
            {
                cliente.Nome = txtNome.Text;
                cliente.Email = txtEmail.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Cep = txtCep.Text;
                cliente.Cidade = cbxCidade.Text;
                cliente.Estado = cbxEstado.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Celular = txtCelular.Text;
                cliente.Cpf = txtCpf.Text;
                cliente.Rg = txtRg.Text;
                cliente.DataCadastro = dtpDataCadastro.Value.Date;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString(), "chronOS", MessageBoxButtons.OK);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
