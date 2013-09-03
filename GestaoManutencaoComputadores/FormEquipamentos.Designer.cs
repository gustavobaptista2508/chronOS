namespace Chronos
{
    partial class FormEquipamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipamentos));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.bgwDataGrid = new System.ComponentModel.BackgroundWorker();
            this.dgvEquipamentos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaMae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemoriaRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscoRigido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaSom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar3 = new System.Windows.Forms.Button();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxOpcao = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNetbooks = new System.Windows.Forms.RadioButton();
            this.rbtnDesktops = new System.Windows.Forms.RadioButton();
            this.rbtnNotebooks = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chbDescricao = new System.Windows.Forms.CheckBox();
            this.chbModelo = new System.Windows.Forms.CheckBox();
            this.chbNumSerie = new System.Windows.Forms.CheckBox();
            this.chbFabricante = new System.Windows.Forms.CheckBox();
            this.chbTipo = new System.Windows.Forms.CheckBox();
            this.chbCliente = new System.Windows.Forms.CheckBox();
            this.chbCpf = new System.Windows.Forms.CheckBox();
            this.chbTelefone = new System.Windows.Forms.CheckBox();
            this.chbPlacaMae = new System.Windows.Forms.CheckBox();
            this.chbProcessador = new System.Windows.Forms.CheckBox();
            this.chbMemoria = new System.Windows.Forms.CheckBox();
            this.chbDiscoRigido = new System.Windows.Forms.CheckBox();
            this.chbPlacaVideo = new System.Windows.Forms.CheckBox();
            this.chbPlacaSom = new System.Windows.Forms.CheckBox();
            this.chbSo = new System.Windows.Forms.CheckBox();
            this.chxCodigo = new System.Windows.Forms.CheckBox();
            this.toolStripStatusLabelNumEquipamentos = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.cmsEquipamentoUsuarios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmVisualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cmsEquipamentoUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(960, 107);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.1018F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.8982F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnNovo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEditar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExcluir, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(256, 100);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(68, 92);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(79, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(71, 92);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(157, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(78, 92);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel1.Controls.Add(this.btnImprimir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExportar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(265, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 99);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(116, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(105, 42);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(4, 4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(105, 42);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // bgwDataGrid
            // 
            this.bgwDataGrid.WorkerReportsProgress = true;
            this.bgwDataGrid.WorkerSupportsCancellation = true;
            this.bgwDataGrid.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDataGrid_DoWork);
            this.bgwDataGrid.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwDataGrid_ProgressChanged);
            this.bgwDataGrid.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDataGrid_RunWorkerCompleted);
            // 
            // dgvEquipamentos
            // 
            this.dgvEquipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DataEntrada,
            this.DataSaida,
            this.Codigo,
            this.Descricao,
            this.Modelo,
            this.NumSerie,
            this.Fabricante,
            this.Tipo,
            this.Cliente,
            this.Cpf,
            this.Telefone,
            this.PlacaMae,
            this.Processador,
            this.MemoriaRam,
            this.DiscoRigido,
            this.PlacaVideo,
            this.PlacaSom,
            this.SO});
            this.dgvEquipamentos.Location = new System.Drawing.Point(16, 163);
            this.dgvEquipamentos.Name = "dgvEquipamentos";
            this.dgvEquipamentos.Size = new System.Drawing.Size(980, 388);
            this.dgvEquipamentos.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.Width = 35;
            // 
            // DataEntrada
            // 
            this.DataEntrada.DataPropertyName = "DataEntrada";
            this.DataEntrada.HeaderText = "Data Entrada";
            this.DataEntrada.Name = "DataEntrada";
            // 
            // DataSaida
            // 
            this.DataSaida.DataPropertyName = "DataSaida";
            this.DataSaida.HeaderText = "Data Saída";
            this.DataSaida.Name = "DataSaida";
            this.DataSaida.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Equipamento";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 170;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // NumSerie
            // 
            this.NumSerie.DataPropertyName = "NumSerie";
            this.NumSerie.HeaderText = "Nº Série";
            this.NumSerie.Name = "NumSerie";
            // 
            // Fabricante
            // 
            this.Fabricante.DataPropertyName = "Fabricante";
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Nome";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 170;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // PlacaMae
            // 
            this.PlacaMae.DataPropertyName = "PlacaMae";
            this.PlacaMae.HeaderText = "Placa-Mãe";
            this.PlacaMae.Name = "PlacaMae";
            this.PlacaMae.Visible = false;
            this.PlacaMae.Width = 180;
            // 
            // Processador
            // 
            this.Processador.DataPropertyName = "Processador";
            this.Processador.HeaderText = "Processador";
            this.Processador.Name = "Processador";
            this.Processador.Visible = false;
            this.Processador.Width = 150;
            // 
            // MemoriaRam
            // 
            this.MemoriaRam.DataPropertyName = "MemoriaRam";
            this.MemoriaRam.HeaderText = "Memória RAM";
            this.MemoriaRam.Name = "MemoriaRam";
            this.MemoriaRam.Visible = false;
            // 
            // DiscoRigido
            // 
            this.DiscoRigido.DataPropertyName = "DiscoRigido";
            this.DiscoRigido.HeaderText = "Disco Rigído (HD)";
            this.DiscoRigido.Name = "DiscoRigido";
            this.DiscoRigido.Visible = false;
            // 
            // PlacaVideo
            // 
            this.PlacaVideo.DataPropertyName = "PlacaVideo";
            this.PlacaVideo.HeaderText = "Placa de Vídeo";
            this.PlacaVideo.Name = "PlacaVideo";
            this.PlacaVideo.Visible = false;
            // 
            // PlacaSom
            // 
            this.PlacaSom.DataPropertyName = "PlacaSom";
            this.PlacaSom.HeaderText = "Placa de Som";
            this.PlacaSom.Name = "PlacaSom";
            this.PlacaSom.Visible = false;
            // 
            // SO
            // 
            this.SO.DataPropertyName = "SistemaOperacional";
            this.SO.HeaderText = "Sistema Operacional";
            this.SO.Name = "SO";
            this.SO.Visible = false;
            this.SO.Width = 170;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.btnAtualizar);
            this.splitContainer1.Panel1.Controls.Add(this.btnAjuda);
            this.splitContainer1.Panel1.Controls.Add(this.btnSair);
            this.splitContainer1.Panel1.Controls.Add(this.lblLogin);
            this.splitContainer1.Panel1.Controls.Add(this.lblPerfil);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lblNome);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.shapeContainer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEquipamentos);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1284, 587);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 16;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(12, 133);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 49);
            this.btnAtualizar.TabIndex = 20;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjuda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAjuda.Image")));
            this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.Location = new System.Drawing.Point(11, 188);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(100, 49);
            this.btnAjuda.TabIndex = 17;
            this.btnAjuda.Text = "Voltar";
            this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(11, 243);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 49);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLogin.Location = new System.Drawing.Point(84, 71);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(70, 13);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Login usuário";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPerfil.Location = new System.Drawing.Point(84, 54);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(67, 13);
            this.lblPerfil.TabIndex = 8;
            this.lblPerfil.Text = "Perfil usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(83, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Computadores";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Location = new System.Drawing.Point(84, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(87, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome do usuário";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 62);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(270, 587);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 12;
            this.lineShape1.X2 = 260;
            this.lineShape1.Y1 = 111;
            this.lineShape1.Y2 = 111;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 145);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 119);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ferramentas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 119);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.dtpEntrada);
            this.groupBox6.Location = new System.Drawing.Point(622, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 47);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Entradas no dia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(6, 19);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(99, 20);
            this.dtpEntrada.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFiltrar3);
            this.groupBox4.Controls.Add(this.cbxFabricante);
            this.groupBox4.Location = new System.Drawing.Point(525, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 59);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtrar por fabricante";
            // 
            // btnFiltrar3
            // 
            this.btnFiltrar3.Location = new System.Drawing.Point(190, 23);
            this.btnFiltrar3.Name = "btnFiltrar3";
            this.btnFiltrar3.Size = new System.Drawing.Size(102, 23);
            this.btnFiltrar3.TabIndex = 5;
            this.btnFiltrar3.Text = "Filtrar";
            this.btnFiltrar3.UseVisualStyleBackColor = true;
            this.btnFiltrar3.Click += new System.EventHandler(this.btnFiltrar3_Click);
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxFabricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(6, 24);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(178, 21);
            this.cbxFabricante.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFiltrar);
            this.groupBox3.Controls.Add(this.cbxCliente);
            this.groupBox3.Location = new System.Drawing.Point(199, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 59);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar por cliente";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(209, 23);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(102, 23);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(6, 24);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(197, 21);
            this.cbxCliente.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxOpcao);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 47);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecione a opção desejada e digite o que você procura:";
            // 
            // cbxOpcao
            // 
            this.cbxOpcao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxOpcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOpcao.FormattingEnabled = true;
            this.cbxOpcao.Items.AddRange(new object[] {
            "Código",
            "Descrição",
            "Modelo",
            "Nº Série",
            "Fabricante",
            "Tipo",
            "Cliente"});
            this.cbxOpcao.Location = new System.Drawing.Point(6, 21);
            this.cbxOpcao.Name = "cbxOpcao";
            this.cbxOpcao.Size = new System.Drawing.Size(121, 21);
            this.cbxOpcao.TabIndex = 16;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(489, 18);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(111, 23);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(133, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 20);
            this.textBox1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNetbooks);
            this.groupBox1.Controls.Add(this.rbtnDesktops);
            this.groupBox1.Controls.Add(this.rbtnNotebooks);
            this.groupBox1.Location = new System.Drawing.Point(6, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 59);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organizar";
            // 
            // rbtnNetbooks
            // 
            this.rbtnNetbooks.AutoSize = true;
            this.rbtnNetbooks.Location = new System.Drawing.Point(89, 13);
            this.rbtnNetbooks.Name = "rbtnNetbooks";
            this.rbtnNetbooks.Size = new System.Drawing.Size(71, 17);
            this.rbtnNetbooks.TabIndex = 2;
            this.rbtnNetbooks.TabStop = true;
            this.rbtnNetbooks.Text = "Netbooks";
            this.rbtnNetbooks.UseVisualStyleBackColor = true;
            this.rbtnNetbooks.CheckedChanged += new System.EventHandler(this.rbtnNetbooks_CheckedChanged);
            // 
            // rbtnDesktops
            // 
            this.rbtnDesktops.AutoSize = true;
            this.rbtnDesktops.Location = new System.Drawing.Point(6, 36);
            this.rbtnDesktops.Name = "rbtnDesktops";
            this.rbtnDesktops.Size = new System.Drawing.Size(70, 17);
            this.rbtnDesktops.TabIndex = 1;
            this.rbtnDesktops.TabStop = true;
            this.rbtnDesktops.Text = "Desktops";
            this.rbtnDesktops.UseVisualStyleBackColor = true;
            this.rbtnDesktops.CheckedChanged += new System.EventHandler(this.rbtnDesktops_CheckedChanged);
            // 
            // rbtnNotebooks
            // 
            this.rbtnNotebooks.AutoSize = true;
            this.rbtnNotebooks.Location = new System.Drawing.Point(6, 13);
            this.rbtnNotebooks.Name = "rbtnNotebooks";
            this.rbtnNotebooks.Size = new System.Drawing.Size(77, 17);
            this.rbtnNotebooks.TabIndex = 0;
            this.rbtnNotebooks.TabStop = true;
            this.rbtnNotebooks.Text = "Notebooks";
            this.rbtnNotebooks.UseVisualStyleBackColor = true;
            this.rbtnNotebooks.CheckedChanged += new System.EventHandler(this.rbtnNotebooks_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(972, 119);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Opções";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel3);
            this.groupBox5.Location = new System.Drawing.Point(8, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(617, 113);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Opções de exibição";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.6899F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.3101F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.tableLayoutPanel3.Controls.Add(this.chbDescricao, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.chbModelo, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.chbNumSerie, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.chbFabricante, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.chbTipo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.chbCliente, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.chbCpf, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.chbTelefone, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.chbPlacaMae, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.chbProcessador, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.chbMemoria, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.chbDiscoRigido, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.chbPlacaVideo, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.chbPlacaSom, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.chbSo, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.chxCodigo, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(597, 94);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // chbDescricao
            // 
            this.chbDescricao.AutoSize = true;
            this.chbDescricao.Checked = true;
            this.chbDescricao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDescricao.Location = new System.Drawing.Point(3, 26);
            this.chbDescricao.Name = "chbDescricao";
            this.chbDescricao.Size = new System.Drawing.Size(74, 17);
            this.chbDescricao.TabIndex = 1;
            this.chbDescricao.Text = "Descrição";
            this.chbDescricao.UseVisualStyleBackColor = true;
            this.chbDescricao.CheckedChanged += new System.EventHandler(this.chbDescricao_CheckedChanged);
            // 
            // chbModelo
            // 
            this.chbModelo.AutoSize = true;
            this.chbModelo.Checked = true;
            this.chbModelo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbModelo.Location = new System.Drawing.Point(3, 49);
            this.chbModelo.Name = "chbModelo";
            this.chbModelo.Size = new System.Drawing.Size(61, 17);
            this.chbModelo.TabIndex = 2;
            this.chbModelo.Text = "Modelo";
            this.chbModelo.UseVisualStyleBackColor = true;
            this.chbModelo.CheckedChanged += new System.EventHandler(this.chbModelo_CheckedChanged);
            // 
            // chbNumSerie
            // 
            this.chbNumSerie.AutoSize = true;
            this.chbNumSerie.Checked = true;
            this.chbNumSerie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNumSerie.Location = new System.Drawing.Point(3, 73);
            this.chbNumSerie.Name = "chbNumSerie";
            this.chbNumSerie.Size = new System.Drawing.Size(65, 17);
            this.chbNumSerie.TabIndex = 3;
            this.chbNumSerie.Text = "Nº Série";
            this.chbNumSerie.UseVisualStyleBackColor = true;
            this.chbNumSerie.CheckedChanged += new System.EventHandler(this.chbNumSerie_CheckedChanged);
            // 
            // chbFabricante
            // 
            this.chbFabricante.AutoSize = true;
            this.chbFabricante.Checked = true;
            this.chbFabricante.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFabricante.Location = new System.Drawing.Point(100, 3);
            this.chbFabricante.Name = "chbFabricante";
            this.chbFabricante.Size = new System.Drawing.Size(76, 17);
            this.chbFabricante.TabIndex = 4;
            this.chbFabricante.Text = "Fabricante";
            this.chbFabricante.UseVisualStyleBackColor = true;
            this.chbFabricante.CheckedChanged += new System.EventHandler(this.chbFabricante_CheckedChanged);
            // 
            // chbTipo
            // 
            this.chbTipo.AutoSize = true;
            this.chbTipo.Checked = true;
            this.chbTipo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTipo.Location = new System.Drawing.Point(100, 26);
            this.chbTipo.Name = "chbTipo";
            this.chbTipo.Size = new System.Drawing.Size(47, 17);
            this.chbTipo.TabIndex = 5;
            this.chbTipo.Text = "Tipo";
            this.chbTipo.UseVisualStyleBackColor = true;
            this.chbTipo.CheckedChanged += new System.EventHandler(this.chbTipo_CheckedChanged);
            // 
            // chbCliente
            // 
            this.chbCliente.AutoSize = true;
            this.chbCliente.Checked = true;
            this.chbCliente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCliente.Location = new System.Drawing.Point(100, 49);
            this.chbCliente.Name = "chbCliente";
            this.chbCliente.Size = new System.Drawing.Size(58, 17);
            this.chbCliente.TabIndex = 6;
            this.chbCliente.Text = "Cliente";
            this.chbCliente.UseVisualStyleBackColor = true;
            this.chbCliente.CheckedChanged += new System.EventHandler(this.chbCliente_CheckedChanged);
            // 
            // chbCpf
            // 
            this.chbCpf.AutoSize = true;
            this.chbCpf.Checked = true;
            this.chbCpf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCpf.Location = new System.Drawing.Point(100, 73);
            this.chbCpf.Name = "chbCpf";
            this.chbCpf.Size = new System.Drawing.Size(46, 17);
            this.chbCpf.TabIndex = 7;
            this.chbCpf.Text = "CPF";
            this.chbCpf.UseVisualStyleBackColor = true;
            this.chbCpf.CheckedChanged += new System.EventHandler(this.chbCpf_CheckedChanged);
            // 
            // chbTelefone
            // 
            this.chbTelefone.AutoSize = true;
            this.chbTelefone.Checked = true;
            this.chbTelefone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTelefone.Location = new System.Drawing.Point(211, 3);
            this.chbTelefone.Name = "chbTelefone";
            this.chbTelefone.Size = new System.Drawing.Size(68, 17);
            this.chbTelefone.TabIndex = 8;
            this.chbTelefone.Text = "Telefone";
            this.chbTelefone.UseVisualStyleBackColor = true;
            this.chbTelefone.CheckedChanged += new System.EventHandler(this.chbTelefone_CheckedChanged);
            // 
            // chbPlacaMae
            // 
            this.chbPlacaMae.AutoSize = true;
            this.chbPlacaMae.Location = new System.Drawing.Point(211, 26);
            this.chbPlacaMae.Name = "chbPlacaMae";
            this.chbPlacaMae.Size = new System.Drawing.Size(77, 17);
            this.chbPlacaMae.TabIndex = 9;
            this.chbPlacaMae.Text = "Placa-Mãe";
            this.chbPlacaMae.UseVisualStyleBackColor = true;
            this.chbPlacaMae.CheckedChanged += new System.EventHandler(this.chbPlacaMae_CheckedChanged);
            // 
            // chbProcessador
            // 
            this.chbProcessador.AutoSize = true;
            this.chbProcessador.Location = new System.Drawing.Point(211, 49);
            this.chbProcessador.Name = "chbProcessador";
            this.chbProcessador.Size = new System.Drawing.Size(85, 17);
            this.chbProcessador.TabIndex = 10;
            this.chbProcessador.Text = "Processador";
            this.chbProcessador.UseVisualStyleBackColor = true;
            this.chbProcessador.CheckedChanged += new System.EventHandler(this.chbProcessador_CheckedChanged);
            // 
            // chbMemoria
            // 
            this.chbMemoria.AutoSize = true;
            this.chbMemoria.Location = new System.Drawing.Point(211, 73);
            this.chbMemoria.Name = "chbMemoria";
            this.chbMemoria.Size = new System.Drawing.Size(93, 17);
            this.chbMemoria.TabIndex = 11;
            this.chbMemoria.Text = "Memória RAM";
            this.chbMemoria.UseVisualStyleBackColor = true;
            this.chbMemoria.CheckedChanged += new System.EventHandler(this.chbMemoria_CheckedChanged);
            // 
            // chbDiscoRigido
            // 
            this.chbDiscoRigido.AutoSize = true;
            this.chbDiscoRigido.Location = new System.Drawing.Point(368, 3);
            this.chbDiscoRigido.Name = "chbDiscoRigido";
            this.chbDiscoRigido.Size = new System.Drawing.Size(88, 17);
            this.chbDiscoRigido.TabIndex = 12;
            this.chbDiscoRigido.Text = "Disco Rigído";
            this.chbDiscoRigido.UseVisualStyleBackColor = true;
            this.chbDiscoRigido.CheckedChanged += new System.EventHandler(this.chbDiscoRigido_CheckedChanged);
            // 
            // chbPlacaVideo
            // 
            this.chbPlacaVideo.AutoSize = true;
            this.chbPlacaVideo.Location = new System.Drawing.Point(368, 26);
            this.chbPlacaVideo.Name = "chbPlacaVideo";
            this.chbPlacaVideo.Size = new System.Drawing.Size(100, 17);
            this.chbPlacaVideo.TabIndex = 13;
            this.chbPlacaVideo.Text = "Placa de Vídeo";
            this.chbPlacaVideo.UseVisualStyleBackColor = true;
            this.chbPlacaVideo.CheckedChanged += new System.EventHandler(this.chbPlacaVideo_CheckedChanged);
            // 
            // chbPlacaSom
            // 
            this.chbPlacaSom.AutoSize = true;
            this.chbPlacaSom.Location = new System.Drawing.Point(368, 49);
            this.chbPlacaSom.Name = "chbPlacaSom";
            this.chbPlacaSom.Size = new System.Drawing.Size(92, 17);
            this.chbPlacaSom.TabIndex = 14;
            this.chbPlacaSom.Text = "Placa de Som";
            this.chbPlacaSom.UseVisualStyleBackColor = true;
            this.chbPlacaSom.CheckedChanged += new System.EventHandler(this.chbPlacaSom_CheckedChanged);
            // 
            // chbSo
            // 
            this.chbSo.AutoSize = true;
            this.chbSo.Location = new System.Drawing.Point(368, 73);
            this.chbSo.Name = "chbSo";
            this.chbSo.Size = new System.Drawing.Size(123, 17);
            this.chbSo.TabIndex = 15;
            this.chbSo.Text = "Sistema Operacional";
            this.chbSo.UseVisualStyleBackColor = true;
            this.chbSo.CheckedChanged += new System.EventHandler(this.chbSo_CheckedChanged);
            // 
            // chxCodigo
            // 
            this.chxCodigo.AutoSize = true;
            this.chxCodigo.Checked = true;
            this.chxCodigo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxCodigo.Location = new System.Drawing.Point(3, 3);
            this.chxCodigo.Name = "chxCodigo";
            this.chxCodigo.Size = new System.Drawing.Size(59, 17);
            this.chxCodigo.TabIndex = 0;
            this.chxCodigo.Text = "Código";
            this.chxCodigo.UseVisualStyleBackColor = true;
            this.chxCodigo.CheckedChanged += new System.EventHandler(this.chxCodigo_CheckedChanged);
            // 
            // toolStripStatusLabelNumEquipamentos
            // 
            this.toolStripStatusLabelNumEquipamentos.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelNumEquipamentos.Name = "toolStripStatusLabelNumEquipamentos";
            this.toolStripStatusLabelNumEquipamentos.Size = new System.Drawing.Size(146, 17);
            this.toolStripStatusLabelNumEquipamentos.Text = "Número de equipamentos";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelNumEquipamentos,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // cmsEquipamentoUsuarios
            // 
            this.cmsEquipamentoUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVisualizar,
            this.tsmEditar,
            this.tsmExcluir});
            this.cmsEquipamentoUsuarios.Name = "cmsEquipamentoUsuarios";
            this.cmsEquipamentoUsuarios.Size = new System.Drawing.Size(153, 92);
            // 
            // tsmVisualizar
            // 
            this.tsmVisualizar.Image = global::Chronos.Properties.Resources._1371073878_invoice;
            this.tsmVisualizar.Name = "tsmVisualizar";
            this.tsmVisualizar.Size = new System.Drawing.Size(152, 22);
            this.tsmVisualizar.Text = "Visualizar";
            // 
            // tsmEditar
            // 
            this.tsmEditar.Image = global::Chronos.Properties.Resources._1364254429_page_white_edit;
            this.tsmEditar.Name = "tsmEditar";
            this.tsmEditar.Size = new System.Drawing.Size(152, 22);
            this.tsmEditar.Text = "Editar";
            // 
            // tsmExcluir
            // 
            this.tsmExcluir.Image = global::Chronos.Properties.Resources._1363893502_document_delete;
            this.tsmExcluir.Name = "tsmExcluir";
            this.tsmExcluir.Size = new System.Drawing.Size(152, 22);
            this.tsmExcluir.Text = "Excluir";
            // 
            // FormEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1284, 587);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEquipamentos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chronOS: Computadores";
            this.Load += new System.EventHandler(this.FormEquipamentos_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cmsEquipamentoUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.ComponentModel.BackgroundWorker bgwDataGrid;
        private System.Windows.Forms.DataGridView dgvEquipamentos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNumEquipamentos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbxOpcao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNetbooks;
        private System.Windows.Forms.RadioButton rbtnDesktops;
        private System.Windows.Forms.RadioButton rbtnNotebooks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxFabricante;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFiltrar3;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox chbDescricao;
        private System.Windows.Forms.CheckBox chbModelo;
        private System.Windows.Forms.CheckBox chbNumSerie;
        private System.Windows.Forms.CheckBox chbFabricante;
        private System.Windows.Forms.CheckBox chbTipo;
        private System.Windows.Forms.CheckBox chbCliente;
        private System.Windows.Forms.CheckBox chbCpf;
        private System.Windows.Forms.CheckBox chbTelefone;
        private System.Windows.Forms.CheckBox chbPlacaMae;
        private System.Windows.Forms.CheckBox chbProcessador;
        private System.Windows.Forms.CheckBox chbMemoria;
        private System.Windows.Forms.CheckBox chbDiscoRigido;
        private System.Windows.Forms.CheckBox chbPlacaVideo;
        private System.Windows.Forms.CheckBox chbPlacaSom;
        private System.Windows.Forms.CheckBox chbSo;
        private System.Windows.Forms.CheckBox chxCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaMae;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processador;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoriaRam;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscoRigido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaSom;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.ContextMenuStrip cmsEquipamentoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmVisualizar;
        private System.Windows.Forms.ToolStripMenuItem tsmEditar;
        private System.Windows.Forms.ToolStripMenuItem tsmExcluir;
    }
}