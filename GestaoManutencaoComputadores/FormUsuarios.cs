using GestaoManutencaoComputadores.Service.Services;
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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void AtualizarGrid()
        {
            dgvUsuario.DataSource = (from Usuario in UsuarioServices.ObterLista()
                                        select new
                                        {
                                            Usuario.Id,
                                            Usuario.Login,
                                            Usuario.Perfil.Perfil,
                                            Usuario.Funcionario.Nome,
                                            Usuario.Email,
                                            Usuario.Ativo                                          
                                        }).ToList();
        }

        private void Contar()
        {
            dgvUsuario.DataSource = (from Usuario in UsuarioServices.ObterLista()
                                        select new
                                        {
                                            Usuario.Id,
                                            Usuario.Login,
                                            Usuario.Perfil.Perfil,
                                            Usuario.Funcionario.Nome,
                                            Usuario.Email,
                                            Usuario.Ativo
                                        }).Count();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            Contar();
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario frm = new FormCadastroUsuario();
            frm.usuario = null;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (UsuarioServices.Inserir(frm.usuario))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    Contar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar novo usuário!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            Contar();
        }
    }
}
