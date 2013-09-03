using Chronos;
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
    public partial class FormLogin : Form
    {
	public bool logado = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        public void AtualizarTextBox()
        {
            SqlConnection conn = Conexao.ObterConexao();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Login FROM Usuario");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            List<UsuarioModel> lista = new List<UsuarioModel>();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        UsuarioModel obj = new UsuarioModel();
                        txtUsuario.Text = leitor["Login"].ToString();
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            AtualizarTextBox();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxLembrar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsuario.Clear();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            txtSenha.Clear();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            txtSenha.Clear();
        }
    }
}
