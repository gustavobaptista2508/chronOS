using Chronos.Service;
using Chronos.Service.Configurar;
using Chronos.Service.Outros;
using GestaoManutencaoComputadores;
using GestaoManutencaoComputadores.Service;
using GestaoManutencaoComputadores.Service.Models;
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
    public partial class FormEquipamentos : Form
    {
        public FormEquipamentos()
        {
            InitializeComponent();
            dgvEquipamentos.AutoGenerateColumns = false;
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

        private void FormEquipamentos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            Permissao(SessaoSistema.Perfil);
            lblLogin.Text = SessaoSistema.Login;
            lblNome.Text = SessaoSistema.Nome;
            lblPerfil.Text = SessaoSistema.Perfil;
            AtualizarCbx();
            Contar();
        }



        private void Contar()
        {
            toolStripStatusLabelNumEquipamentos.Text = "Nº de itens: " + (from Equipamento in EquipamentoServices.ObterLista()
                                                                              select new
                                                                              {
                                                                                  Equipamento.Id,
                                                                                  Equipamento.Equipamento,
                                                                                  Equipamento.Modelo,
                                                                                  Equipamento.Fabricante,
                                                                                  Equipamento.Tipo,
                                                                                  Equipamento.Codigo,
                                                                                  Equipamento.Cliente.Nome,
                                                                                  Equipamento.Cliente.Cpf,
                                                                                  Equipamento.Cliente.Telefone,
                                                                                  Equipamento.NumSerie,
                                                                                  Equipamento.PlacaMae,
                                                                                  Equipamento.Processador,
                                                                                  Equipamento.MemoriaRam,
                                                                                  Equipamento.DiscoRigido,
                                                                                  Equipamento.PlacaVideo,
                                                                                  Equipamento.PlacaSom,
                                                                                  Equipamento.Sistema.SistemaOperacional,
                                                                                  Equipamento.DataEntrada,
                                                                                  Equipamento.DataSaida
                                                                              }).Count().ToString();
        }

        private void AtualizarGrid()
        {
            dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                          select new
                                          {
                                              Equipamento.Id,
                                              Equipamento.Equipamento,
                                              Equipamento.Modelo,
                                              Equipamento.Fabricante,
                                              Equipamento.Tipo,
                                              Equipamento.Codigo,
                                              Equipamento.Cliente.Nome,
                                              Equipamento.Cliente.Cpf,
                                              Equipamento.Cliente.Telefone,
                                              Equipamento.NumSerie,
                                              Equipamento.PlacaMae,
                                              Equipamento.Processador,
                                              Equipamento.MemoriaRam,
                                              Equipamento.DiscoRigido,
                                              Equipamento.PlacaVideo,
                                              Equipamento.PlacaSom,
                                              Equipamento.Sistema.SistemaOperacional,
                                              Equipamento.DataEntrada,
                                              Equipamento.DataSaida
                                          }).ToList();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroEquipamento frm = new FormCadastroEquipamento();
            frm.equipamento = null;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (EquipamentoServices.Inserir(frm.equipamento))
                {
                    MessageBox.Show("Computador cadastrado com sucesso!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    Contar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar novo computador!", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormCadastroEquipamento frm = new FormCadastroEquipamento();
            if (dgvEquipamentos.CurrentRow != null)
            {
                frm.equipamento = EquipamentoServices.ObterPorId(Convert.ToInt32(dgvEquipamentos.CurrentRow.Cells[0].Value));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (EquipamentoServices.Alterar(frm.equipamento))
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

        private void AtualizarCbx()
        {
            cbxCliente.ValueMember = "Id";
            cbxCliente.DisplayMember = "Nome";
            cbxCliente.DataSource = ClienteServices.ObterLista();

            cbxFabricante.ValueMember = "Id";
            cbxFabricante.DisplayMember = "Fabricante";
            cbxFabricante.DataSource = EquipamentoServices.ObterLista();
        }

        private void FiltrarPorFabrincate()
        {
            dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                          select new
                                          {
                                              Equipamento.Id,
                                              Equipamento.Equipamento,
                                              Equipamento.Modelo,
                                              Equipamento.Fabricante,
                                              Equipamento.Tipo,
                                              Equipamento.Codigo,
                                              Equipamento.Cliente.Nome,
                                              Equipamento.Cliente.Cpf,
                                              Equipamento.Cliente.Telefone,
                                              Equipamento.NumSerie,
                                              Equipamento.PlacaMae,
                                              Equipamento.Processador,
                                              Equipamento.MemoriaRam,
                                              Equipamento.DiscoRigido,
                                              Equipamento.PlacaVideo,
                                              Equipamento.PlacaSom,
                                              Equipamento.Sistema.SistemaOperacional,
                                              Equipamento.DataEntrada,
                                              Equipamento.DataSaida
                                          }).Where(x => x.Fabricante == cbxFabricante.Text).OrderBy(x=>x.Fabricante).ToList();
            Contar();
        }

        private void FiltrarPorCliente()
        {
            dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                          select new
                                          {
                                              Equipamento.Id,
                                              Equipamento.Equipamento,
                                              Equipamento.Modelo,
                                              Equipamento.Fabricante,
                                              Equipamento.Tipo,
                                              Equipamento.Codigo,
                                              Equipamento.Cliente.Nome,
                                              Equipamento.Cliente.Cpf,
                                              Equipamento.Cliente.Telefone,
                                              Equipamento.NumSerie,
                                              Equipamento.PlacaMae,
                                              Equipamento.Processador,
                                              Equipamento.MemoriaRam,
                                              Equipamento.DiscoRigido,
                                              Equipamento.PlacaVideo,
                                              Equipamento.PlacaSom,
                                              Equipamento.Sistema.SistemaOperacional,
                                              Equipamento.DataEntrada,
                                              Equipamento.DataSaida
                                          }).Where(x => x.Nome == cbxCliente.Text).OrderBy(x=>x.Nome).ToList();
            Contar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvEquipamentos.CurrentRow != null)
            {
                if (MessageBox.Show("Deseja realmente excluir o equipamento selecionado do sistema?", "Chronos¹",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Todos os dados serão perdidos, tem certeza que deseja continuar? ", "Chronos¹",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        if (EquipamentoServices.Excluir(Convert.ToInt32(dgvEquipamentos.CurrentRow.Cells[0].Value)))
                        {
                            MessageBox.Show("Equipamento excluído com sucesso!",
                           "Chronos¹",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarGrid();
                            Contar();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível excluir o equipamento selecionado!",
                                "Chronos¹",
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
            for (i = 0; i <= dgvEquipamentos.RowCount - 1; i++)
            {
                for (j = 0; j <= dgvEquipamentos.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgvEquipamentos[j, i];
                    WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            try
            {
                salvar.Title = "Exportar para Microsoft Office Excel";
                salvar.FileName = "Chronos_Equipamentos_Export_" + DateTime.Now.ToString("dd_MM_yyyy");
                salvar.Filter = "Arquivo do Excel *.xls|*.xls";
                salvar.ShowDialog();
                WorkBook.SaveAs(salvar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                WorkBook.Close(true, misValue, misValue);
                App.Quit();
                MessageBox.Show("Exportação realizada com sucesso!", "Chronos");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel realizar a exportação." + Environment.NewLine + erro.Message.ToString(), "Chronos");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDGV.Print_DataGridView(dgvEquipamentos);
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            Contar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbxOpcao.Text == "Código")
            {
                dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                              select new
                                              {
                                                  Equipamento.Id,
                                                  Equipamento.Equipamento,
                                                  Equipamento.Modelo,
                                                  Equipamento.Fabricante,
                                                  Equipamento.Tipo,
                                                  Equipamento.Codigo,
                                                  Equipamento.Cliente.Nome,
                                                  Equipamento.Cliente.Cpf,
                                                  Equipamento.Cliente.Telefone,
                                                  Equipamento.NumSerie,
                                                  Equipamento.PlacaMae,
                                                  Equipamento.Processador,
                                                  Equipamento.MemoriaRam,
                                                  Equipamento.DiscoRigido,
                                                  Equipamento.PlacaVideo,
                                                  Equipamento.PlacaSom,
                                                  Equipamento.Sistema.SistemaOperacional,
                                                  Equipamento.DataEntrada,
                                                  Equipamento.DataSaida
                                              }).Where(x => x.Codigo == textBox1.Text).ToList();
                Contar();
            }
            if (cbxOpcao.Text == "Descrição")
            {
                dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                              select new
                                              {
                                                  Equipamento.Id,
                                                  Equipamento.Equipamento,
                                                  Equipamento.Modelo,
                                                  Equipamento.Fabricante,
                                                  Equipamento.Tipo,
                                                  Equipamento.Codigo,
                                                  Equipamento.Cliente.Nome,
                                                  Equipamento.Cliente.Cpf,
                                                  Equipamento.Cliente.Telefone,
                                                  Equipamento.NumSerie,
                                                  Equipamento.PlacaMae,
                                                  Equipamento.Processador,
                                                  Equipamento.MemoriaRam,
                                                  Equipamento.DiscoRigido,
                                                  Equipamento.PlacaVideo,
                                                  Equipamento.PlacaSom,
                                                  Equipamento.Sistema.SistemaOperacional,
                                                  Equipamento.DataEntrada,
                                                  Equipamento.DataSaida
                                              }).Where(x => x.Equipamento == textBox1.Text).ToList();
                Contar();
            }
            if (cbxOpcao.Text == "Modelo")
            {
                dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                              select new
                                              {
                                                  Equipamento.Id,
                                                  Equipamento.Equipamento,
                                                  Equipamento.Modelo,
                                                  Equipamento.Fabricante,
                                                  Equipamento.Tipo,
                                                  Equipamento.Codigo,
                                                  Equipamento.Cliente.Nome,
                                                  Equipamento.Cliente.Cpf,
                                                  Equipamento.Cliente.Telefone,
                                                  Equipamento.NumSerie,
                                                  Equipamento.PlacaMae,
                                                  Equipamento.Processador,
                                                  Equipamento.MemoriaRam,
                                                  Equipamento.DiscoRigido,
                                                  Equipamento.PlacaVideo,
                                                  Equipamento.PlacaSom,
                                                  Equipamento.Sistema.SistemaOperacional,
                                                  Equipamento.DataEntrada,
                                                  Equipamento.DataSaida
                                              }).Where(x => x.Modelo == textBox1.Text).ToList();
                Contar();
            }
            if (cbxOpcao.Text == "Fabricante")
            {
                dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                              select new
                                              {
                                                  Equipamento.Id,
                                                  Equipamento.Equipamento,
                                                  Equipamento.Modelo,
                                                  Equipamento.Fabricante,
                                                  Equipamento.Tipo,
                                                  Equipamento.Codigo,
                                                  Equipamento.Cliente.Nome,
                                                  Equipamento.Cliente.Cpf,
                                                  Equipamento.Cliente.Telefone,
                                                  Equipamento.NumSerie,
                                                  Equipamento.PlacaMae,
                                                  Equipamento.Processador,
                                                  Equipamento.MemoriaRam,
                                                  Equipamento.DiscoRigido,
                                                  Equipamento.PlacaVideo,
                                                  Equipamento.PlacaSom,
                                                  Equipamento.Sistema.SistemaOperacional,
                                                  Equipamento.DataEntrada,
                                                  Equipamento.DataSaida
                                              }).Where(x => x.Fabricante == textBox1.Text).ToList();
                Contar();
            }
            if (cbxOpcao.Text == "Tipo")
            {
                dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                              select new
                                              {
                                                  Equipamento.Id,
                                                  Equipamento.Equipamento,
                                                  Equipamento.Modelo,
                                                  Equipamento.Fabricante,
                                                  Equipamento.Tipo,
                                                  Equipamento.Codigo,
                                                  Equipamento.Cliente.Nome,
                                                  Equipamento.Cliente.Cpf,
                                                  Equipamento.Cliente.Telefone,
                                                  Equipamento.NumSerie,
                                                  Equipamento.PlacaMae,
                                                  Equipamento.Processador,
                                                  Equipamento.MemoriaRam,
                                                  Equipamento.DiscoRigido,
                                                  Equipamento.PlacaVideo,
                                                  Equipamento.PlacaSom,
                                                  Equipamento.Sistema.SistemaOperacional,
                                                  Equipamento.DataEntrada,
                                                  Equipamento.DataSaida
                                              }).Where(x => x.Tipo == textBox1.Text).ToList();
                Contar();
            }
            if (cbxOpcao.Text == "Cliente")
            {
                dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                              select new
                                              {
                                                  Equipamento.Id,
                                                  Equipamento.Equipamento,
                                                  Equipamento.Modelo,
                                                  Equipamento.Fabricante,
                                                  Equipamento.Tipo,
                                                  Equipamento.Codigo,
                                                  Equipamento.Cliente.Nome,
                                                  Equipamento.Cliente.Cpf,
                                                  Equipamento.Cliente.Telefone,
                                                  Equipamento.NumSerie,
                                                  Equipamento.PlacaMae,
                                                  Equipamento.Processador,
                                                  Equipamento.MemoriaRam,
                                                  Equipamento.DiscoRigido,
                                                  Equipamento.PlacaVideo,
                                                  Equipamento.PlacaSom,
                                                  Equipamento.Sistema.SistemaOperacional,
                                                  Equipamento.DataEntrada,
                                                  Equipamento.DataSaida
                                              }).Where(x => x.Nome == textBox1.Text).ToList();
                Contar();
            }
            if (cbxOpcao.Text == "N° Série")
            {
                dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                              select new
                                              {
                                                  Equipamento.Id,
                                                  Equipamento.Equipamento,
                                                  Equipamento.Modelo,
                                                  Equipamento.Fabricante,
                                                  Equipamento.Tipo,
                                                  Equipamento.Codigo,
                                                  Equipamento.Cliente.Nome,
                                                  Equipamento.Cliente.Cpf,
                                                  Equipamento.Cliente.Telefone,
                                                  Equipamento.NumSerie,
                                                  Equipamento.PlacaMae,
                                                  Equipamento.Processador,
                                                  Equipamento.MemoriaRam,
                                                  Equipamento.DiscoRigido,
                                                  Equipamento.PlacaVideo,
                                                  Equipamento.PlacaSom,
                                                  Equipamento.Sistema.SistemaOperacional,
                                                  Equipamento.DataEntrada,
                                                  Equipamento.DataSaida
                                              }).Where(x => x.NumSerie == textBox1.Text).ToList();
                Contar();
            }
        }

        private void rbtnNotebooks_CheckedChanged(object sender, EventArgs e)
        {
            dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                          select new
                                          {
                                              Equipamento.Id,
                                              Equipamento.Equipamento,
                                              Equipamento.Modelo,
                                              Equipamento.Fabricante,
                                              Equipamento.Tipo,
                                              Equipamento.Codigo,
                                              Equipamento.Cliente.Nome,
                                              Equipamento.Cliente.Cpf,
                                              Equipamento.Cliente.Telefone,
                                              Equipamento.NumSerie,
                                              Equipamento.PlacaMae,
                                              Equipamento.Processador,
                                              Equipamento.MemoriaRam,
                                              Equipamento.DiscoRigido,
                                              Equipamento.PlacaVideo,
                                              Equipamento.PlacaSom,
                                              Equipamento.Sistema.SistemaOperacional,
                                              Equipamento.DataEntrada,
                                              Equipamento.DataSaida
                                          }).Where(x => x.Tipo == "Notebook").ToList();
            Contar();
        }

        private void rbtnDesktops_CheckedChanged(object sender, EventArgs e)
        {
            dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                          select new
                                          {
                                              Equipamento.Id,
                                              Equipamento.Equipamento,
                                              Equipamento.Modelo,
                                              Equipamento.Fabricante,
                                              Equipamento.Tipo,
                                              Equipamento.Codigo,
                                              Equipamento.Cliente.Nome,
                                              Equipamento.Cliente.Cpf,
                                              Equipamento.Cliente.Telefone,
                                              Equipamento.NumSerie,
                                              Equipamento.PlacaMae,
                                              Equipamento.Processador,
                                              Equipamento.MemoriaRam,
                                              Equipamento.DiscoRigido,
                                              Equipamento.PlacaVideo,
                                              Equipamento.PlacaSom,
                                              Equipamento.Sistema.SistemaOperacional,
                                              Equipamento.DataEntrada,
                                              Equipamento.DataSaida
                                          }).Where(x => x.Tipo == "Desktop").ToList();
            Contar();
        }

        private void rbtnNetbooks_CheckedChanged(object sender, EventArgs e)
        {
            dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                          select new
                                          {
                                              Equipamento.Id,
                                              Equipamento.Equipamento,
                                              Equipamento.Modelo,
                                              Equipamento.Fabricante,
                                              Equipamento.Tipo,
                                              Equipamento.Codigo,
                                              Equipamento.Cliente.Nome,
                                              Equipamento.Cliente.Cpf,
                                              Equipamento.Cliente.Telefone,
                                              Equipamento.NumSerie,
                                              Equipamento.PlacaMae,
                                              Equipamento.Processador,
                                              Equipamento.MemoriaRam,
                                              Equipamento.DiscoRigido,
                                              Equipamento.PlacaVideo,
                                              Equipamento.PlacaSom,
                                              Equipamento.Sistema.SistemaOperacional,
                                              Equipamento.DataEntrada,
                                              Equipamento.DataSaida
                                          }).Where(x => x.Tipo == "Netbook").ToList();
            Contar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarPorCliente();
        }

        private void btnFiltrar3_Click(object sender, EventArgs e)
        {
            FiltrarPorFabrincate();

        }

        private void chxCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (chxCodigo.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["Codigo"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["Codigo"].Visible = false;
            }
        }

        private void chbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDescricao.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["Descricao"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["Descricao"].Visible = false;
            }
        }

        private void chbModelo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbModelo.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["Modelo"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["Modelo"].Visible = false;
            }
        }

        private void chbNumSerie_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNumSerie.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["NumSerie"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["NumSerie"].Visible = false;
            }
        }

        private void chbFabricante_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFabricante.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["Fabricante"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["Fabricante"].Visible = false;
            }
        }

        private void chbTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTipo.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["Tipo"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["Tipo"].Visible = false;
            }
        }

        private void chbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCliente.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["Cliente"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["Cliente"].Visible = false;
            }
        }

        private void chbCpf_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCpf.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["Cpf"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["Cpf"].Visible = false;
            }
        }

        private void chbTelefone_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTelefone.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["Telefone"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["Telefone"].Visible = false;
            }
        }

        private void chbPlacaMae_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPlacaMae.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["PlacaMae"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["PlacaMae"].Visible = false;
            }
        }

        private void chbProcessador_CheckedChanged(object sender, EventArgs e)
        {
            if (chbProcessador.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["Processador"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["Processador"].Visible = false;
            }
        }

        private void chbMemoria_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMemoria.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["MemoriaRam"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["MemoriaRam"].Visible = false;
            }
        }

        private void chbDiscoRigido_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDiscoRigido.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["DiscoRigido"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["DiscoRigido"].Visible = false;
            }
        }

        private void chbPlacaVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPlacaVideo.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["PlacaVideo"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["PlacaVideo"].Visible = false;
            }
        }

        private void chbPlacaSom_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPlacaSom.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["PlacaSom"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["PlacaSom"].Visible = false;
            }
        }

        private void chbSo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSo.CheckState == CheckState.Checked)
            {
                dgvEquipamentos.Columns["So"].Visible = true;
            }
            else
            {
                dgvEquipamentos.Columns["So"].Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                          select new
                                          {
                                              Equipamento.Id,
                                              Equipamento.Equipamento,
                                              Equipamento.Modelo,
                                              Equipamento.Fabricante,
                                              Equipamento.Tipo,
                                              Equipamento.Codigo,
                                              Equipamento.Cliente.Nome,
                                              Equipamento.Cliente.Cpf,
                                              Equipamento.Cliente.Telefone,
                                              Equipamento.NumSerie,
                                              Equipamento.PlacaMae,
                                              Equipamento.Processador,
                                              Equipamento.MemoriaRam,
                                              Equipamento.DiscoRigido,
                                              Equipamento.PlacaVideo,
                                              Equipamento.PlacaSom,
                                              Equipamento.Sistema.SistemaOperacional,
                                              Equipamento.DataEntrada,
                                              Equipamento.DataSaida
                                          }).Where(x => x.DataEntrada == dtpEntrada.Value.Date).ToList();
            Contar();
        }

        private void bgwDataGrid_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    dgvEquipamentos.DataSource = (from Equipamento in EquipamentoServices.ObterLista()
                                                  select new
                                                  {
                                                      Equipamento.Id,
                                                      Equipamento.Equipamento,
                                                      Equipamento.Modelo,
                                                      Equipamento.Fabricante,
                                                      Equipamento.Tipo,
                                                      Equipamento.Codigo,
                                                      Equipamento.Cliente.Nome,
                                                      Equipamento.Cliente.Cpf,
                                                      Equipamento.Cliente.Telefone,
                                                      Equipamento.NumSerie,
                                                      Equipamento.PlacaMae,
                                                      Equipamento.Processador,
                                                      Equipamento.MemoriaRam,
                                                      Equipamento.DiscoRigido,
                                                      Equipamento.PlacaVideo,
                                                      Equipamento.PlacaSom,
                                                      Equipamento.Sistema.SistemaOperacional,
                                                      Equipamento.DataEntrada,
                                                      Equipamento.DataSaida
                                                  }).ToList();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message.ToString(), "chronOS");
                }
            }
        }

        private void bgwDataGrid_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (bgwDataGrid.CancellationPending != true)
            {
                toolStripProgressBar1.Visible = true;
                toolStripProgressBar1.Value = e.ProgressPercentage;
                toolStripStatusLabelNumEquipamentos.Text = "Processando "+e.ProgressPercentage.ToString() + "%";
            }
        }

        private void bgwDataGrid_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Visible = false;
            Contar();
        }
    }
}
