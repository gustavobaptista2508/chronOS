using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chronos.Service.Properties;
using System.Data.Sql;
using Chronos.Service.Configurar;
using Chronos.Service;
using System.Data.SqlClient;
using GestaoManutencaoComputadores.Service;
using System.Threading;
using System.IO;

namespace Chronos
{
    public partial class FormConfigurar : Form
    {
        public FormConfigurar()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            cbxConexoes.DisplayMember = "ServerName";
            cbxConexoes.DataSource = instance.GetDataSources();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar?", "chronOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void FormConfigurar_Load(object sender, EventArgs e)
        {
            var StringBuilder = Configuracoes.ObterConnectionString();
            cbxConexoes.Text = StringBuilder.DataSource;
            var dir = AppDomain.CurrentDomain.BaseDirectory + "chronConfig.dat";
            if (File.Exists(dir))
            {
                rbtnConexaoRemota.Checked = true;
                rbtnLocal.Checked = false;
                txtNomeBanco.Text = StringBuilder.InitialCatalog;
                txtUsuarioServer.Text = StringBuilder.UserID;
                txtSenhaServer.Text = StringBuilder.Password;

            }
            else
            {
                rbtnConexaoRemota.Checked = false;
                rbtnLocal.Checked = true;
                txtNomeBanco.Enabled = false;
                txtUsuarioServer.Enabled = false;
                txtSenhaServer.Enabled = false;
                cbxConexoes.Enabled = false;
            }
            lblLogin.Text = SessaoSistema.Login;
            lblNome.Text = SessaoSistema.Nome;
            lblPerfil.Text = SessaoSistema.Perfil;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Configuracoes.GravarConfig(cbxConexoes.Text, txtNomeBanco.Text, txtUsuarioServer.Text, txtSenhaServer.Text))
            {
                if (Configuracoes.ConexaoSucesso())
                {
                    MessageBox.Show("Configurações salvas com sucesso!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (DialogResult == DialogResult.OK)
                    {
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao realizar tentativa de conexão", "chronOS");
                }
            }
            else
            {
                MessageBox.Show("Não foi possível salvar ás configurações", "chronOS");
            }
        }

        private void txtNomeBanco_Leave(object sender, EventArgs e)
        {
            btnGravar.Enabled = true;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (Configuracoes.ConexaoSucesso())
                {
                    MessageBox.Show("Teste de conexão realizado com sucesso!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao realizar tentativa de conexão", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString(), "chronOS");
            }
        }

        private void rbtnLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLocal.Checked == true)
            {
                var dir = AppDomain.CurrentDomain.BaseDirectory + "chronConfig.dat";
                if (File.Exists(dir))
                {
                    File.Delete(dir);
                    txtNomeBanco.Enabled = false;
                    txtUsuarioServer.Enabled = false;
                    txtSenhaServer.Enabled = false;
                    cbxConexoes.Enabled = false;
                    txtNomeBanco.Clear();
                    txtSenhaServer.Clear();
                    txtUsuarioServer.Clear();
                }
                else
                {
                    txtNomeBanco.Enabled = false;
                    txtUsuarioServer.Enabled = false;
                    txtSenhaServer.Enabled = false;
                    cbxConexoes.Enabled = false;
                    txtNomeBanco.Clear();
                    txtSenhaServer.Clear();
                    txtUsuarioServer.Clear();
                }
            }
            else
            {
                txtNomeBanco.Enabled = true;
                txtUsuarioServer.Enabled = true;
                txtSenhaServer.Enabled = true;
                cbxConexoes.Enabled = true;
                txtNomeBanco.Clear();
                txtSenhaServer.Clear();
                txtUsuarioServer.Clear();
            }
        }

        private void cbxConexoes_SelectedValueChanged(object sender, EventArgs e)
        {
            txtNomeBanco.Clear();
            txtSenhaServer.Clear();
            txtUsuarioServer.Clear();
        }

        private void rbtnConexaoRemota_CheckedChanged(object sender, EventArgs e)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory + "chronConfig.dat";
            if (rbtnConexaoRemota.Checked == true)
            {
                txtNomeBanco.Enabled = true;
                txtUsuarioServer.Enabled = true;
                txtSenhaServer.Enabled = true;
                cbxConexoes.Enabled = true;
                txtNomeBanco.Clear();
                txtSenhaServer.Clear();
                txtUsuarioServer.Clear();
            }
            else
            {
                if (File.Exists(dir))
                {
                    File.Delete(dir);
                    txtNomeBanco.Enabled = false;
                    txtUsuarioServer.Enabled = false;
                    txtSenhaServer.Enabled = false;
                    cbxConexoes.Enabled = false;
                    txtNomeBanco.Clear();
                    txtSenhaServer.Clear();
                    txtUsuarioServer.Clear();
                }
                else
                {
                    txtNomeBanco.Enabled = false;
                    txtUsuarioServer.Enabled = false;
                    txtSenhaServer.Enabled = false;
                    cbxConexoes.Enabled = false;
                    txtNomeBanco.Clear();
                    txtSenhaServer.Clear();
                    txtUsuarioServer.Clear();
                }
            }
        }
    }
}
