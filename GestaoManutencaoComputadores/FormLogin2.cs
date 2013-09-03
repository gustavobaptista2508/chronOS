using Chronos.Service;
using Chronos.Service.Models;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos
{
    public partial class FormLogin2 : Form
    {
        public bool logado = false;
        public string usuario, senha;
        public static string Login, Senha;

        public FormLogin2()
        {
            InitializeComponent();
        }

        private void AtualizarTextBox()
        {
            Thread.Sleep(100);
        }

        public void Entrar()
        {

            SqlConnection conn = Conexao.ObterConexao();
            try
            {
                usuario = txtUsuario.Text;
                senha = txtSenha.Text;
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT COUNT(Id) FROM Usuario WHERE Usuario = @Usuario OR Email = @Email AND Senha = @Senha AND Ativo = 'Sim'");
                SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txtUsuario.Text;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtUsuario.Text;
                cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtSenha.Text;
                conn.Open();
                int v = (int)cmd.ExecuteScalar();
                if (v > 0)
                {
                    logado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário/Senha inválidos, favor tente novamente", "chronOS");
                    logado = false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString(), "chronOS");
            }
            finally
            {
                conn.Close();
            }
        }

        public List<UsuarioModel> Acesso()
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();
            SqlConnection conn = Conexao.ObterConexao();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Usuario.Id, Usuario.Usuario, Usuario.Email, Perfil.Perfil, Funcionario.Nome, Usuario.Ativo ");
            sql.Append("FROM Usuario INNER JOIN Perfil ON Perfil.Id=Usuario.IdPerfil INNER JOIN Funcionario ON Funcionario.Id=Usuario.IdFuncionario WHERE Usuario.Usuario = '" + txtUsuario.Text + "' OR Usuario.Email = '" + txtUsuario.Text + "' AND Usuario.Senha = '" + txtSenha.Text + "'");
            using (SqlCommand cmd = new SqlCommand(sql.ToString(), conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader leitor = cmd.ExecuteReader();
                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            UsuarioModel obj = new UsuarioModel();
                            obj.Perfil = new PerfilModel();
                            obj.Funcionario = new FuncionarioModel();
                            obj.Id = Convert.ToInt32(leitor["Id"]);
                            obj.Login = leitor["Usuario"].ToString();
                            obj.Perfil.Perfil = leitor["Perfil"].ToString();
                            obj.Funcionario.Nome = leitor["Nome"].ToString();
                            obj.Ativo = leitor["Ativo"].ToString();
                            obj.Email = leitor["Email"].ToString();
                            lista.Add(obj);
                        }
                    }
                    leitor.Close();
                    try
                    {
                        SessaoSistema.Nome = lista[0].Funcionario.Nome;
                        SessaoSistema.Perfil = lista[0].Perfil.Perfil;
                        SessaoSistema.Login = lista[0].Login;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message.ToString(), "chronOS");
                    }
                }
                catch (SqlException erro)
                {
                    MessageBox.Show(erro.Message.ToString(), "chronOS");
                }
                finally
                {

                    conn.Close();
                }
            }
            return lista;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bgwLogin.RunWorkerAsync();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void bgwLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                bgwLogin.ReportProgress(i);
                Acesso();
            }
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString(), "chronOS");
            }
        }

        private void bgwLogin_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (bgwLogin.CancellationPending != true)
            {
                lblDados.Text = "Aguarde... " + e.ProgressPercentage.ToString() + "%";
                btnCancelar.Text = "Cancelar";
                btnOk.Enabled = false;
                txtSenha.Enabled = false;
                txtUsuario.Enabled = false;
            }
        }

        private void bgwLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblDados.Text = "Entrada cancelada";
                lblDados.Text = "Digite os dados de login";
                btnCancelar.Text = "Sair";
                btnOk.Enabled = true;
                txtSenha.Enabled = true;
                txtUsuario.Enabled = true;
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message.ToString(), "chronOS");
                btnCancelar.Text = "Sair";
                lblDados.Text = "Digite os dados de login";
            }
            else
            {
                Entrar();
            }
        }
    }
}
