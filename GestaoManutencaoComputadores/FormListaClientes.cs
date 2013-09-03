using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoManutencaoComputadores.Service.Services;
using System.Data.SqlClient;
using GestaoManutencaoComputadores.Service;
using Chronos;
using Chronos.Service;
using Chronos.Service.Services;
using Chronos.Service.Outros;

namespace GestaoManutencaoComputadores
{
    public partial class FormListaClientes : Form
    {
        public FormListaClientes()
        {
            InitializeComponent();
        }

        private void AtualizarCbx()
        {
            cbxCidade.ValueMember = "Id";
            cbxCidade.DisplayMember = "Nome";
            cbxCidade.DataSource = CidadeService.ObterLista();
        }

        public void AtualizarGrid()
        {
            dgvClientes.DataSource = (from Cliente in ClienteServices.ObterLista()
                                      select new
                                      {
                                          Cliente.Id,
                                          Cliente.Nome,
                                          Cliente.Email,
                                          Cliente.Estado,
                                          Cliente.Cidade,
                                          Cliente.Bairro,
                                          Cliente.Endereco,
                                          Cliente.Telefone,
                                          Cliente.Celular,
                                          Cliente.Cep,
                                          Cliente.Cpf,
                                          Cliente.Rg,
                                          Cliente.DataCadastro
                                      }).ToList();
        }

        public decimal linhas { get; set; }
        public void Contar()
        {
            toolStripStatusLabelNumClientes.Text = "Nº de cadastros: " + (from Cliente in ClienteServices.ObterLista()
                                      select new
                                      {
                                          Cliente.Id,
                                          Cliente.Nome,
                                          Cliente.Email,
                                          Cliente.Estado,
                                          Cliente.Cidade,
                                          Cliente.Bairro,
                                          Cliente.Endereco,
                                          Cliente.Telefone,
                                          Cliente.Celular,
                                          Cliente.Cep,
                                          Cliente.Cpf,
                                          Cliente.Rg,
                                          Cliente.DataCadastro
                                      }).Count().ToString();
        }

        private void Permissao(string perfil)
        {
            switch (perfil)
            {
                case "Atendente":
                    btnAjuda.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnEditar.Text = "Visualizar";
                    btnEditar.Image = Chronos.Properties.Resources._1375298011_old_edit_find;
                    btnExportar.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            AtualizarCbx();
            Contar();
            lblLogin.Text = SessaoSistema.Login;
            lblNome.Text = SessaoSistema.Nome;
            lblPerfil.Text = SessaoSistema.Perfil;
            Permissao(SessaoSistema.Perfil);
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
                            dgvClientes.DataSource = (from Cliente in ClienteServices.ObterLista()
                                          select new
                                          {
                                              Cliente.Id,
                                              Cliente.Nome,
                                              Cliente.Email,
                                              Cliente.Estado,
                                              Cliente.Cidade,
                                              Cliente.Bairro,
                                              Cliente.Endereco,
                                              Cliente.Telefone,
                                              Cliente.Celular,
                                              Cliente.Cep,
                                              Cliente.Cpf,
                                              Cliente.Rg,
                                              Cliente.DataCadastro
                                          }).Where(x => x.Nome == txtPesquisa.Text).ToList();
            Contar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastrarCliente frm = new FormCadastrarCliente();
            frm.cliente = null;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (ClienteServices.Inserir(frm.cliente))
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "chronOS",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    Contar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar novo cliente!", "chronOS",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormCadastrarCliente alterar = new FormCadastrarCliente();
            if (dgvClientes.CurrentRow != null)
            {
                alterar.cliente = ClienteServices.ObterPorId(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
                if (alterar.ShowDialog() == DialogResult.OK)
                {
                    if (ClienteServices.Alterar(alterar.cliente))
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
            if (dgvClientes.CurrentRow != null)
            {
                if (MessageBox.Show("Deseja realmente excluir o cliente selecionado?", " chronOS",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Todos os dados serão perdidos, tem certeza que deseja excluir o registro? ", "chronOS",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        if (ClienteServices.Excluir(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value)))
                        {
                            MessageBox.Show("Cliente excluído com sucesso!",
                           "chronOS",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarGrid();
                            Contar();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Excluir cliente!",
                                "chronOS",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnExportar_Click_1(object sender, EventArgs e)
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
            for (i = 0; i <= dgvClientes.RowCount - 1; i++)
            {
                for (j = 0; j <= dgvClientes.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgvClientes[j, i];
                    WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            try
            {
                salvar.Title = "Exportar para Microsoft Office Excel";
                salvar.FileName = "Chronos_Clientes_"+DateTime.Now.ToString("dd_MM_yyyy");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvClientes.DataSource = (from Cliente in ClienteServices.ObterLista()
                                      select new
                                      {
                                          Cliente.Id,
                                          Cliente.Nome,
                                          Cliente.Email,
                                          Cliente.Estado,
                                          Cliente.Cidade,
                                          Cliente.Bairro,
                                          Cliente.Endereco,
                                          Cliente.Telefone,
                                          Cliente.Celular,
                                          Cliente.Cep,
                                          Cliente.Cpf,
                                          Cliente.Rg,
                                          Cliente.DataCadastro
                                      }).Where(x => x.DataCadastro == dtpDataUm.Value.Date).ToList();
            Contar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = (from Cliente in ClienteServices.ObterLista()
                                      select new
                                      {
                                          Cliente.Id,
                                          Cliente.Nome,
                                          Cliente.Email,
                                          Cliente.Estado,
                                          Cliente.Cidade,
                                          Cliente.Bairro,
                                          Cliente.Endereco,
                                          Cliente.Telefone,
                                          Cliente.Celular,
                                          Cliente.Cep,
                                          Cliente.Cpf,
                                          Cliente.Rg,
                                          Cliente.DataCadastro
                                      }).Where(x => x.Cidade == cbxCidade.Text).OrderByDescending(x=>x.Cidade).ToList();
            Contar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDGV.Print_DataGridView(dgvClientes);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = (from Cliente in ClienteServices.ObterLista()
                                      select new
                                      {
                                          Cliente.Id,
                                          Cliente.Nome,
                                          Cliente.Email,
                                          Cliente.Estado,
                                          Cliente.Cidade,
                                          Cliente.Bairro,
                                          Cliente.Endereco,
                                          Cliente.Telefone,
                                          Cliente.Celular,
                                          Cliente.Cep,
                                          Cliente.Cpf,
                                          Cliente.Rg,
                                          Cliente.DataCadastro
                                      }).Where(x => x.Nome == txtPesquisa.Text).ToList();
            Contar();
        }
    }
}
