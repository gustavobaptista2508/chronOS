using Chronos.Service;
using Chronos.Service.Outros;
using Chronos.Service.Services;
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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void AtualizarGrid()
        {
            dgvProdutos.DataSource = (from Produto in ProdutoService.ObterLista()
                                      select new
                                      {
                                          Produto.Id,
                                          Produto.Descricao,
                                          Produto.Codigo,
                                          Produto.Fabricante,
                                          Produto.CodigoBarras,
                                          Produto.NumEstoque,
                                          Produto.Preco,
                                          Produto.Fornecedor,
                                          Produto.DataEntrada,
                                          Produto.Unidade,
                                          Produto.PrecoVenda,
                                          Produto.Grupo
                                      }).ToList();
        }

        private void Contar()
        {
            toolStripStatusLabelNumCadastros.Text = "Nº de intes: " + (from Produto in ProdutoService.ObterLista()
                                                                       select new
                                                                       {
                                                                           Produto.Id,
                                                                           Produto.Descricao,
                                                                           Produto.Codigo,
                                                                           Produto.Fabricante,
                                                                           Produto.CodigoBarras,
                                                                           Produto.NumEstoque,
                                                                           Produto.Preco,
                                                                           Produto.Fornecedor,
                                                                           Produto.DataEntrada,
                                                                           Produto.Unidade,
                                                                           Produto.PrecoVenda,
                                                                           Produto.Grupo
                                                                       }).Count();
        }

        private void AtualizarCbx()
        {
            cbxFabricante.ValueMember = "Id";
            cbxFabricante.DisplayMember = "Fabricante";
            cbxFabricante.DataSource = ProdutoService.ObterLista();

            cbxFornecedor.ValueMember = "Id";
            cbxFornecedor.DisplayMember = "Fornecedor";
            cbxFornecedor.DataSource = ProdutoService.ObterLista();
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
                    btnImprimir.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroProd frm = new FormCadastroProd();
            frm.produto = null;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (ProdutoService.Inserir(frm.produto))
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    Contar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormCadastroProd frm = new FormCadastroProd();
            if (dgvProdutos.CurrentRow != null)
            {
                frm.produto = ProdutoService.ObterPorId(Convert.ToInt32(dgvProdutos.CurrentRow.Cells[0].Value));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (ProdutoService.Alterar(frm.produto))
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
            if (dgvProdutos.CurrentRow != null)
            {
                if (MessageBox.Show("Deseja realmente excluir o produto selecionado?", " chronOS",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Todos os dados serão perdidos, tem certeza que deseja excluir o registro? ", "chronOS",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        if (ProdutoService.Excluir(Convert.ToInt32(dgvProdutos.CurrentRow.Cells[0].Value)))
                        {
                            MessageBox.Show("Produto excluído com sucesso!",
                           "chronOS",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarGrid();
                            Contar();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir produto!",
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
            for (i = 0; i <= dgvProdutos.RowCount - 1; i++)
            {
                for (j = 0; j <= dgvProdutos.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgvProdutos[j, i];
                    WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            try
            {
                salvar.Title = "Exportar para Microsoft Office Excel";
                salvar.FileName = "Chronos_Clientes_" + DateTime.Now.ToString("dd_MM_yyyy");
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
            printDGV.Print_DataGridView(dgvProdutos);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
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

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            AtualizarCbx();
            Contar();
            lblLogin.Text = SessaoSistema.Login;
            lblNome.Text = SessaoSistema.Nome;
            lblPerfil.Text = SessaoSistema.Perfil;
            //Permissao(SessaoSistema.Perfil);
        }

        private void cbxFabricante_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = (from Produto in ProdutoService.ObterLista()
                                      select new
                                      {
                                          Produto.Id,
                                          Produto.Descricao,
                                          Produto.Codigo,
                                          Produto.Fabricante,
                                          Produto.CodigoBarras,
                                          Produto.NumEstoque,
                                          Produto.Preco,
                                          Produto.Fornecedor,
                                          Produto.DataEntrada,
                                          Produto.Unidade,
                                          Produto.PrecoVenda,
                                          Produto.Grupo
                                      }).Where(x=>x.Fabricante == cbxFabricante.Text).ToList();
            Contar();
        }

        private void cbxGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = (from Produto in ProdutoService.ObterLista()
                                      select new
                                      {
                                          Produto.Id,
                                          Produto.Descricao,
                                          Produto.Codigo,
                                          Produto.Fabricante,
                                          Produto.CodigoBarras,
                                          Produto.NumEstoque,
                                          Produto.Preco,
                                          Produto.Fornecedor,
                                          Produto.DataEntrada,
                                          Produto.Unidade,
                                          Produto.PrecoVenda,
                                          Produto.Grupo
                                      }).Where(x => x.Grupo == cbxGrupo.Text).ToList();
            Contar();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = (from Produto in ProdutoService.ObterLista()
                                      select new
                                      {
                                          Produto.Id,
                                          Produto.Descricao,
                                          Produto.Codigo,
                                          Produto.Fabricante,
                                          Produto.CodigoBarras,
                                          Produto.NumEstoque,
                                          Produto.Preco,
                                          Produto.Fornecedor,
                                          Produto.DataEntrada,
                                          Produto.Unidade,
                                          Produto.PrecoVenda,
                                          Produto.Grupo
                                      }).Where(x => x.Descricao == txtPesquisa.Text).ToList();
            Contar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = (from Produto in ProdutoService.ObterLista()
                                      select new
                                      {
                                          Produto.Id,
                                          Produto.Descricao,
                                          Produto.Codigo,
                                          Produto.Fabricante,
                                          Produto.CodigoBarras,
                                          Produto.NumEstoque,
                                          Produto.Preco,
                                          Produto.Fornecedor,
                                          Produto.DataEntrada,
                                          Produto.Unidade,
                                          Produto.PrecoVenda,
                                          Produto.Grupo
                                      }).Where(x => x.CodigoBarras == txtCodigoBarras.Text).ToList();
            Contar();
            
        }
    }
}
