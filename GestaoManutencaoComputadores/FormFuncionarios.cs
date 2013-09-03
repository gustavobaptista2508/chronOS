using Chronos.Service;
using Chronos.Service.Outros;
using Chronos.Service.Services;
using GestaoManutencaoComputadores.Service.Models;
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
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }

        private void AtualizarCbx()
        {
            cbxFuncoes.ValueMember = "Id";
            cbxFuncoes.DisplayMember = "Funcao";
            cbxFuncoes.DataSource = FuncaoService.ObterLista();
        }

        private void Contar()
        {
            toolStripStatusLabelnumeroFuncionarios.Text = "Nº de funcionários: " + (from Funcionario in FuncionarioService.ObterLista()
                                                           select new
                                                           {
                                                               Funcionario.Id,
                                                               Funcionario.Codigo,
                                                               Funcionario.DataCadastro,
                                                               Funcionario.Nome,
                                                               Funcionario.Cpf,
                                                               Funcionario.Rg,
                                                               Funcionario.Celular,
                                                               Funcionario.Telefone,
                                                               Funcionario.Endereco,
                                                               Funcionario.Bairro,
                                                               Funcionario.Cep,
                                                               Funcionario.Cidade,
                                                               Funcionario.Estado,
                                                               Funcionario.Funcao.Funcao,
                                                               Funcionario.DataAdmissao,
                                                               Funcionario.Ativo
                                                           }).Count().ToString();
        }

        private void AtualizarGrid()
        {
            dataGridView1.DataSource = (from Funcionario in FuncionarioService.ObterLista()
                                        select new
                                        {
                                            Funcionario.Id,
                                            Funcionario.Codigo,
                                            Funcionario.DataCadastro,
                                            Funcionario.Nome,
                                            Funcionario.Cpf,
                                            Funcionario.Rg,
                                            Funcionario.Celular,
                                            Funcionario.Telefone,
                                            Funcionario.Endereco,
                                            Funcionario.Bairro,
                                            Funcionario.Cep,
                                            Funcionario.Cidade,
                                            Funcionario.Estado,
                                            Funcionario.Funcao.Funcao,
                                            Funcionario.DataAdmissao,
                                            Funcionario.Ativo
                                        }).ToList();
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            lblLogin.Text = SessaoSistema.Login;
            lblNome.Text = SessaoSistema.Nome;
            lblPerfil.Text = SessaoSistema.Perfil;
            AtualizarCbx();
            AtualizarGrid();
            Contar();
        }

        private void FiltrarPorFuncao()
        {
            dataGridView1.DataSource = (from Funcionario in FuncionarioService.ObterLista()
                                        select new
                                        {
                                            Funcionario.Id,
                                            Funcionario.Codigo,
                                            Funcionario.DataCadastro,
                                            Funcionario.Nome,
                                            Funcionario.Cpf,
                                            Funcionario.Rg,
                                            Funcionario.Celular,
                                            Funcionario.Telefone,
                                            Funcionario.Endereco,
                                            Funcionario.Bairro,
                                            Funcionario.Cep,
                                            Funcionario.Cidade,
                                            Funcionario.Estado,
                                            Funcionario.Funcao.Funcao,
                                            Funcionario.DataAdmissao,
                                            Funcionario.Ativo
                                        }).Where(x => x.Funcao == cbxFuncoes.Text).OrderBy(x=>x.Funcao).ToList();
            Contar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastroFunc cadastroFunc = new FormCadastroFunc();
            cadastroFunc.funcionario = null;
            if (cadastroFunc.ShowDialog() == DialogResult.OK)
            {
                if(FuncionarioService.Inserir(cadastroFunc.funcionario))
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    Contar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar novo funcionário!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            try
            {
                salvar.Title = "Exportar para Microsoft Office Excel";
                salvar.FileName = "Chronos_Funcionários_Export_" + DateTime.Now.ToString("dd_MM_yyyy");
                salvar.Filter = "Arquivo do Excel *.xls|*.xls";
                salvar.ShowDialog();
                WorkBook.SaveAs(salvar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                WorkBook.Close(true, misValue, misValue);
                App.Quit();
                MessageBox.Show("Exportação realizada com sucesso!", "chronOS");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel realizar a exportação." + Environment.NewLine + erro.Message.ToString(), "chronOS");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormCadastroFunc alterar = new FormCadastroFunc();
            if (dataGridView1.CurrentRow != null)
            {
                alterar.funcionario = FuncionarioService.ObterPorId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (alterar.ShowDialog() == DialogResult.OK)
                {
                    if (FuncionarioService.Alterar(alterar.funcionario))
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
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show("Deseja realmente excluir o funcionário selecionado do sistema?", "chronOS",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Todos os dados serão perdidos, tem certeza que deseja continuar?", "chronOS",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        if (FuncionarioService.Excluir(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)))
                        {
                            MessageBox.Show("Funcionário excluído com sucesso!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarGrid();
                            Contar();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível excluir o funcionário selecionado!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            this.Close();
            //FormPrincipal2 frm = new FormPrincipal2();
            //frm.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar?", "chronOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            Contar();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDGV.Print_DataGridView(dataGridView1);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarPorFuncao();
        }

        private void btnFiltrar2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from Funcionario in FuncionarioService.ObterLista()
                                        select new
                                        {
                                            Funcionario.Id,
                                            Funcionario.Codigo,
                                            Funcionario.DataCadastro,
                                            Funcionario.Nome,
                                            Funcionario.Cpf,
                                            Funcionario.Rg,
                                            Funcionario.Celular,
                                            Funcionario.Telefone,
                                            Funcionario.Endereco,
                                            Funcionario.Bairro,
                                            Funcionario.Cep,
                                            Funcionario.Cidade,
                                            Funcionario.Estado,
                                            Funcionario.Funcao.Funcao,
                                            Funcionario.DataAdmissao,
                                            Funcionario.Ativo
                                        }).Where(x => x.DataCadastro == dtpCadastro.Value.Date).OrderBy(x => x.DataCadastro).ToList();
            Contar();
        }
    }
}
