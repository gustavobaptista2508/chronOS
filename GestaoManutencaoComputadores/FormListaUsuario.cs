using Chronos.Service;
using Chronos.Service.Outros;
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
    public partial class FormListaUsuario : Form
    {
        public FormListaUsuario()
        {
            InitializeComponent();
        }

        private void AtualizarCbx()
        {
            cbxFuncoes.ValueMember = "Id";
            cbxFuncoes.DisplayMember = "Perfil";
            cbxFuncoes.DataSource = PerfilServices.ObterLista();
        }

        private void AtualizarGrid()
        {
            dgvUsuarios.DataSource = (from Usuario in UsuarioServices.ObterLista()
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
           toolStripStatusLabelContar.Text = "Nº de cadastros: " + (from Usuario in UsuarioServices.ObterLista()
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormListaUsuario_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            Contar();
            lblLogin.Text = SessaoSistema.Login;
            lblNome.Text = SessaoSistema.Nome;
            lblPerfil.Text = SessaoSistema.Perfil;
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = (from Usuario in UsuarioServices.ObterLista()
                                      select new
                                      {
                                          Usuario.Id,
                                          Usuario.Login,
                                          Usuario.Perfil.Perfil,
                                          Usuario.Funcionario.Nome,
                                          Usuario.Email,
                                          Usuario.Ativo
                                      }).Where(x=>x.Perfil == cbxFuncoes.Text).ToList();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario frm = new FormCadastroUsuario();
            if (dgvUsuarios.CurrentRow != null)
            {
                frm.usuario = UsuarioServices.ObterPorId(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (UsuarioServices.Alterar(frm.usuario))
                    {
                        MessageBox.Show("Alteração realizada com sucesso!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                        Contar();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível realizar a alteração no momento!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                if (MessageBox.Show("Deseja realmente excluir o usuário selecionado?", " chronOS",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Todos os dados serão perdidos, tem certeza que deseja excluir o registro? ", "chronOS",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        if (UsuarioServices.Excluir(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value)))
                        {
                            MessageBox.Show("Usuário excluído com sucesso!",
                           "chronOS",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarGrid();
                            Contar();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Excluir usuário!",
                                "chronOS",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();
            Microsoft.Office.Interop.Excel.Application App;
            Microsoft.Office.Interop.Excel.Workbook WorkBook;
            Microsoft.Office.Interop.Excel.Worksheet WorkSheet;
            object misValue = System.Reflection.Missing.Value;
            App = new Microsoft.Office.Interop.Excel.Application();
            WorkBook = App.Workbooks.Add(misValue);
            WorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (i = 0; i <= dgvUsuarios.RowCount - 1; i++)
            {
                for (j = 0; j <= dgvUsuarios.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgvUsuarios[j, i];
                    WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            try
            {
                salvar.Title = "Exportar para Microsoft Office Excel";
                salvar.FileName = "Chronos_Usuarios_" + DateTime.Now.ToString("dd_MM_yyyy");
                salvar.Filter = "Arquivo do Excel *.xls|*.xls";
                salvar.ShowDialog();
                WorkBook.SaveAs(salvar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                WorkBook.Close(true, misValue, misValue);
                App.Quit();
                MessageBox.Show("Exportado com sucesso!", "chronOS");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel realizar a exportação." + Environment.NewLine + erro.Message.ToString(), "chronOS");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDGV.Print_DataGridView(dgvUsuarios);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = (from Usuario in UsuarioServices.ObterLista()
                                      select new
                                      {
                                          Usuario.Id,
                                          Usuario.Login,
                                          Usuario.Perfil.Perfil,
                                          Usuario.Funcionario.Nome,
                                          Usuario.Email,
                                          Usuario.Ativo
                                      }).Where(x=>x.Nome == textBox1.Text).ToList();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            AtualizarGrid();
            Contar();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar?", "chronOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                checkBox2.CheckState = CheckState.Unchecked;
                dgvUsuarios.DataSource = (from Usuario in UsuarioServices.ObterLista()
                                          select new
                                          {
                                              Usuario.Id,
                                              Usuario.Login,
                                              Usuario.Perfil.Perfil,
                                              Usuario.Funcionario.Nome,
                                              Usuario.Email,
                                              Usuario.Ativo
                                          }).Where(x => x.Ativo == "Sim").ToList();
                Contar();
            }
            else
            {
                AtualizarGrid();
                Contar();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                checkBox1.CheckState = CheckState.Unchecked;
                dgvUsuarios.DataSource = (from Usuario in UsuarioServices.ObterLista()
                                          select new
                                          {
                                              Usuario.Id,
                                              Usuario.Login,
                                              Usuario.Perfil.Perfil,
                                              Usuario.Funcionario.Nome,
                                              Usuario.Email,
                                              Usuario.Ativo
                                          }).Where(x => x.Ativo == "Não").ToList();
                Contar();
            }
            else
            {
                AtualizarGrid();
                Contar();
            }
        }

        private void tsmEditar_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario frm = new FormCadastroUsuario();
            if (dgvUsuarios.CurrentRow != null)
            {
                frm.usuario = UsuarioServices.ObterPorId(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (UsuarioServices.Alterar(frm.usuario))
                    {
                        MessageBox.Show("Alteração realizada com sucesso!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                        Contar();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível realizar a alteração no momento!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void tsmExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                if (MessageBox.Show("Deseja realmente excluir o usuário selecionado?", " chronOS",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Todos os dados serão perdidos, tem certeza que deseja excluir o registro? ", "chronOS",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        if (UsuarioServices.Excluir(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value)))
                        {
                            MessageBox.Show("Usuário excluído com sucesso!",
                           "chronOS",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarGrid();
                            Contar();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Excluir usuário!",
                                "chronOS",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
