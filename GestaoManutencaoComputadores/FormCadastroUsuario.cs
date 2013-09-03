using Chronos.Classes;
using GestaoManutencaoComputadores.Service;
using GestaoManutencaoComputadores.Service.Models;
using GestaoManutencaoComputadores.Service.Services;
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
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
            txtUsuario.MaxLength = 12;
            txtSenha.MaxLength = 16;
        }

        public UsuarioModel usuario;

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            AtualizarCbx();
            if (usuario != null)
            {
                txtUsuario.Text = usuario.Login;
                cbxPerfil.SelectedValue = usuario.Perfil.Id;
                cbxFuncionario.SelectedValue = usuario.Funcionario.Id;
                if (usuario.Ativo == "Sim")
                {
                    checkBoxAtivo.CheckState = CheckState.Checked;
                }
                else
                {
                    checkBoxAtivo.CheckState = CheckState.Unchecked;
                }
                txtUsuario.Text = usuario.Login;
                txtEmail.Text = usuario.Email;
                this.Text = "chronOS: Usuário (Alteração - " + usuario.Funcionario.Nome + " - " + usuario.Login+")";
            }
        }

        private void AtualizarCbx()
        {
            cbxPerfil.ValueMember = "Id";
            cbxPerfil.DisplayMember = "Perfil";
            cbxPerfil.DataSource = PerfilServices.ObterLista();

            cbxFuncionario.ValueMember = "Id";
            cbxFuncionario.DisplayMember = "Nome";
            cbxFuncionario.DataSource = FuncionarioService.ObterLista();
        }

        private void Existente()
        {
            string nome = null;
            int Id;
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Funcionario.Nome, Usuario.Usuario, Usuario.IdFuncionario FROM Usuario INNER JOIN Funcionario ON Usuario.IdFuncionario = Funcionario.Id WHERE IdFuncionario = " + cbxFuncionario.SelectedValue);
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    nome = leitor["Nome"].ToString();
                    Id = Convert.ToInt32(leitor["IdFuncionario"]);
                    if (Convert.ToInt32(cbxFuncionario.SelectedValue) == Id)
                    {
                        MessageBox.Show(nome.ToString() + "já possui um login cadastrado no sistema!", "chronOS");
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

        private void VerificarForca()
        {
            if (txtSenha.Text != String.Empty)
            {
                SenhaForca verifica = new SenhaForca();
                int placar;
                ForcaDaSenha forca;
                placar = verifica.geraPontosSenha(txtSenha.Text);
                forca = verifica.GetForcaDaSenha(txtSenha.Text);
                lblSenhaForca.Text = forca.ToString();
                lblSenhaForca.Visible = true;
                if (forca.ToString() == "Inaceitável")
                {
                    lblSenhaForca.ForeColor = Color.Red;
                }
                if (forca.ToString() == "Fraca")
                {
                    lblSenhaForca.ForeColor = Color.Orange;
                }
                if (forca.ToString() == "Aceitável")
                {
                    lblSenhaForca.ForeColor = Color.Yellow;
                }
                if (forca.ToString() == "Forte")
                {
                    lblSenhaForca.ForeColor = Color.Blue;
                }
                if (forca.ToString() == "Segura")
                {
                    lblSenhaForca.ForeColor = Color.Green;
                }
            }
        }

        private void ConfirmarSenha()
        {
            if (txtSenha.Text != txtConfSenha.Text)
            {
                lblConfirmar.Visible = true;
                lblConfirmar.Text = "Senhas incompatíveis";
                lblConfirmar.ForeColor = Color.Red;
                txtConfSenha.Focus();
                txtConfSenha.Clear();
            }
            else
            {
                lblConfirmar.Visible = false;
            }
        }

        private void txtConfSenha_Leave(object sender, EventArgs e)
        {
            ConfirmarSenha();
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            VerificarForca();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (usuario == null)
            {
                usuario = new UsuarioModel();
                usuario.Funcionario = new Service.Models.FuncionarioModel();
                usuario.Perfil = new PerfilModel();
            }
            try
            {
                usuario.Login = txtUsuario.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Funcionario.Id = Convert.ToInt32(cbxFuncionario.SelectedValue);
                if(checkBoxAtivo.CheckState == CheckState.Checked)
               {
                   usuario.Ativo = "Sim";
               }
                else
                {
                    usuario.Ativo = "Não";
                }
                usuario.Perfil.Id = Convert.ToInt32(cbxPerfil.SelectedValue);
                usuario.Email = txtEmail.Text;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString(), "chronOS", MessageBoxButtons.OK);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            Existente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
