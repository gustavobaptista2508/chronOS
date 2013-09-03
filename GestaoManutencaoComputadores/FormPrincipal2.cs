using Chronos.Classes;
using Chronos.Service;
using Chronos.Service.Models;
using GestaoManutencaoComputadores;
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

namespace Chronos
{
    public partial class FormPrincipal2 : Form
    {
        public FormPrincipal2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormListaUsuario frm = new FormListaUsuario();
            frm.ShowDialog();
        }

        private void Permissao(string perfil)
        {
            switch (perfil)
            {
                case "Atendente":
                    btnAjuda.Enabled = true;
                    btnAtendimento.Enabled = true;
                    btnClientes.Enabled = true;
                    btnComputadores.Enabled = true;
                    btnOs.Enabled = true;
                    btnUsuarios.Enabled = false;
                    btnOpcoes.Enabled = false;
                    btnFuncionarios.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormFuncionarios frm = new FormFuncionarios();
            //this.Hide();
            frm.ShowDialog();
        }

        private void UltimoRegistroFuncionarios()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT MAX (Nome) FROM Funcionario");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            try
            {
                conn.Open();
                ToolTipHelper.ShowToolTip(out toolTip1, btnFuncionarios, "Informações", "Último cadastrado realizado: " + cmd.ExecuteScalar().ToString());
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
        }

        private void UltimoRegistroCliente()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT MAX (Nome) FROM Cliente");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            try
            {
                conn.Open();
                ToolTipHelper.ShowToolTip(out toolTip1, btnClientes, "Informações", "Último cadastrado realizado: " + cmd.ExecuteScalar().ToString());
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
        }
        private void UltimoRegistroComputador()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT MAX (Descricao) FROM Computador");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            try
            {
                conn.Open();
                ToolTipHelper.ShowToolTip(out toolTip1, btnClientes, "Informações", "Último cadastrado realizado: " + cmd.ExecuteScalar().ToString());
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
        }

        private void UltimoRegistroUsuario()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT MAX (Funcionario.Nome) FROM Usuario INNER JOIN Funcionario ON Usuario.IdFuncionario = Funcionario.Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            try
            {
                conn.Open();
                if (SessaoSistema.Perfil == "Atendente")
                {
                    ToolTipHelper.ShowToolTip(out toolTip1, btnUsuarios, "Informações", "Você precisa de permissão do Administrador");
                }
                else
                {
                    ToolTipHelper.ShowToolTip(out toolTip1, btnUsuarios, "Informações", "Último cadastrado realizado: " + cmd.ExecuteScalar().ToString());
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            UltimoRegistroUsuario();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            UltimoRegistroFuncionarios();
        }

        private void btnComputadores_Click(object sender, EventArgs e)
        {
            FormEquipamentos frm = new FormEquipamentos();
            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar?", "chronOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            
        }

        private void FormPrincipal2_Load(object sender, EventArgs e)
        {
            lblLogin.Text = SessaoSistema.Login;
            lblNome.Text = SessaoSistema.Nome;
            lblPerfil.Text = SessaoSistema.Perfil;
            Permissao(SessaoSistema.Perfil);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormListaClientes frm = new FormListaClientes();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConfigurar frm = new FormConfigurar();
            frm.ShowDialog();
        }

        private void btnComputadores_MouseHover(object sender, EventArgs e)
        {
            UltimoRegistroComputador();
        }

        private void btnClientes_MouseHover(object sender, EventArgs e)
        {
            UltimoRegistroCliente();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos frm = new FormProdutos();
            frm.ShowDialog();
        }
    }
}
