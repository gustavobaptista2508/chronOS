using Chronos.Service;
using Chronos.Service.Models;
using Chronos.Service.Services;
using GestaoManutencaoComputadores.Service;
using GestaoManutencaoComputadores.Service.Models;
using GestaoManutencaoComputadores.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos
{
    public partial class FormCadastroEquipamento : Form
    {
        public FormCadastroEquipamento()
        {
            InitializeComponent();
            Random codigo = new Random();
            txtCodigo.Text = Convert.ToString(codigo.Next(1000, 10000));
            txtCodigo.Enabled = false;
        }

        public EquipamentoModel equipamento;

        private void Permissao(string perfil)
        {
            switch (perfil)
            {
                case "Atendente":
                    btnSalvar.Visible = false;
                    txtBairro.Enabled = false;
                    txtCidade.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtDescricao.Enabled = false;
                    txtNumSerie.Enabled = false;
                    txtCpf.Enabled = false;
                    cbxCliente.Enabled = false;
                    cbxFabricante.Enabled = false;
                    cbxModelo.Enabled = false;
                    cbxTipo.Enabled = false;
                    cbxUf.Enabled = false;
                    cbxMemoria.Enabled = false;
                    cbxPlacaMae.Enabled = false;
                    cbxPlacaSom.Enabled = false;
                    cbxVGA.Enabled = false;
                    cbxSo.Enabled = false;
                    btnCancelar.Text = "Voltar";
                    break;
                default:
                    break;
            }
        }

        private void AtualizarCbx()
        {
            cbxCliente.ValueMember = "Id";
            cbxCliente.DisplayMember = "Nome";
            cbxCliente.DataSource = ClienteServices.ObterLista();

            cbxFabricante.ValueMember = "Fabricante";
            cbxFabricante.DisplayMember = "Fabricante";
            cbxFabricante.DataSource = EquipamentoServices.ObterLista();

            cbxModelo.ValueMember = "Modelo";
            cbxModelo.DisplayMember = "Modelo";
            cbxModelo.DataSource = EquipamentoServices.ObterLista();

            cbxDiscoRigido.ValueMember = "DiscoRigido";
            cbxDiscoRigido.DisplayMember = "DiscoRigido";
            cbxDiscoRigido.DataSource = EquipamentoServices.ObterLista();

            cbxMemoria.ValueMember = "MemoriaRam";
            cbxMemoria.DisplayMember = "MemoriaRam";
            cbxMemoria.DataSource = EquipamentoServices.ObterLista();

            cbxPlacaMae.ValueMember = "PlacaMae";
            cbxPlacaMae.DisplayMember = "PlacaMae";
            cbxPlacaMae.DataSource = EquipamentoServices.ObterLista();

            cbxPlacaSom.ValueMember = "PlacaSom";
            cbxPlacaSom.DisplayMember = "PlacaSom";
            cbxPlacaSom.DataSource = EquipamentoServices.ObterLista();

            cbxVGA.ValueMember = "PlacaVideo";
            cbxVGA.DisplayMember = "PlacaVideo";
            cbxVGA.DataSource = EquipamentoServices.ObterLista();

            cbxSo.ValueMember = "Id";
            cbxSo.DisplayMember = "SistemaOperacional";
            cbxSo.DataSource = SistemaOperacionalService.ObterLista();

            cbxProcessador.ValueMember = "Processador";
            cbxProcessador.DisplayMember = "Processador";
            cbxProcessador.DataSource = EquipamentoServices.ObterLista();
        }

        private void Existente()
        {
            string numSerie = null;
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT NumSerie FROM Computador WHERE NumSerie = '"+txtNumSerie.Text+"'");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    numSerie = leitor["NumSerie"].ToString();
                    if (txtNumSerie.Text == numSerie)
                    {
                        MessageBox.Show("Um computador com o mesmo Número de Série  já se encontra cadastrado no sistema", "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNumSerie.Clear();
                        txtNumSerie.Focus();
                    }
                    leitor.Dispose();
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            
        }

        private void FormCadastroEquipamento_Load(object sender, EventArgs e)
        {
            AtualizarCbx();
            PreencherTextBox();
            dtpSaida.Enabled = false;
            if (equipamento != null)
            {
                LerObs();
                Permissao(SessaoSistema.Perfil);
                dtpEntrada.Enabled = false;
                dtpSaida.Enabled = true;
                cbxCliente.SelectedValue = equipamento.Cliente.Id;
                cbxFabricante.Text = equipamento.Fabricante;
                cbxModelo.Text = equipamento.Modelo;
                cbxTipo.Text = equipamento.Tipo;
                txtDescricao.Text = equipamento.Equipamento;
                txtNumSerie.Text = equipamento.NumSerie;
                txtCodigo.Text = Convert.ToString(equipamento.Codigo);
                cbxSo.SelectedValue = equipamento.Sistema.Id;
                cbxPlacaSom.Text = equipamento.PlacaSom;
                cbxPlacaMae.Text = equipamento.PlacaMae;
                cbxMemoria.Text = equipamento.MemoriaRam;
                cbxDiscoRigido.Text = equipamento.DiscoRigido;
                cbxVGA.Text = equipamento.PlacaVideo;
                cbxProcessador.Text = equipamento.Processador;
                dtpEntrada.Value = equipamento.DataEntrada.Date;
                dtpSaida.Value = equipamento.DataSaida.Date;
                this.Text = "Computador - " + equipamento.Codigo.ToString();
            }
        }

        private void cbxCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            PreencherTextBox();
        }

        private void PreencherTextBox()
        {
            txtBairro.Text = Preencher.PreecherBairro(cbxCliente.Text);
            txtCelular.Text = Preencher.PreecherCelular(cbxCliente.Text);
            txtCep.Text = Preencher.PreecherCep(cbxCliente.Text);
            txtCidade.Text = Preencher.PreecherCidade(cbxCliente.Text);
            txtCpf.Text = Preencher.PreecherCpf(cbxCliente.Text);
            txtEndereco.Text = Preencher.PreecherEndereco(cbxCliente.Text);
            txtRg.Text = Preencher.PreecherRg(cbxCliente.Text);
            txtTelefone.Text = Preencher.PreecherTelefone(cbxCliente.Text);
            cbxUf.Text = Preencher.PreecherEstado(cbxCliente.Text);
        }

        private void txtNumSerie_Leave(object sender, EventArgs e)
        {
            Existente();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (equipamento == null)
            {
                dtpSaida.Enabled = false;
                equipamento = new EquipamentoModel();
                equipamento.Cliente = new ClienteModel();
                equipamento.Sistema = new SistemaOperacionalModel();
            }
            try
            {
                equipamento.Cliente.Id = Convert.ToInt32(cbxCliente.SelectedValue);
                equipamento.Sistema.Id = Convert.ToInt32(cbxSo.SelectedValue);
                equipamento.Codigo = txtCodigo.Text;
                equipamento.Equipamento = txtDescricao.Text;
                equipamento.NumSerie = txtNumSerie.Text;
                equipamento.Modelo = cbxModelo.Text;
                equipamento.Tipo = cbxTipo.Text;
                equipamento.Fabricante = cbxFabricante.Text;
                equipamento.PlacaMae = cbxPlacaMae.Text;
                equipamento.PlacaSom = cbxPlacaSom.Text;
                equipamento.PlacaVideo = cbxVGA.Text;
                equipamento.MemoriaRam = cbxMemoria.Text;
                equipamento.DiscoRigido = cbxDiscoRigido.Text;
                equipamento.Processador = cbxProcessador.Text;
                equipamento.DataEntrada = dtpEntrada.Value.Date;
                equipamento.DataSaida = dtpSaida.Value.Date;
                GravarObs();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "chronOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GravarObs()
        {
            string CaminhoArquivo = AppDomain.CurrentDomain.BaseDirectory + "Observações\\Obs-"+txtCodigo.Text+" - "+txtNumSerie.Text+".cos";
            StreamWriter escrever = new StreamWriter(CaminhoArquivo);
            escrever.WriteLine(DateTime.Now.ToString("dd/MM/yyyy") + " - " + SessaoSistema.Nome.ToString() + ":" + Environment.NewLine + txtObservacao.Text);
            escrever.Close();
        }

        private void LerObs()
        {
            string CaminhoArquivo = AppDomain.CurrentDomain.BaseDirectory + "Observações\\Obs-" + equipamento.Codigo + " - " + equipamento.NumSerie + ".cos";
            if (File.Exists(CaminhoArquivo))
            {
                StreamReader leitor = new StreamReader(CaminhoArquivo);
                string linha = leitor.ReadToEnd();
                txtObservacao.Text = linha.ToString();         
                leitor.Close();
            }
        }
    }
}
