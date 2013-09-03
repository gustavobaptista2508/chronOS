namespace Chronos
{
    partial class FormCadastroProd
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxUnidade = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label23);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 51);
            this.panel2.TabIndex = 18;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(362, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(188, 26);
            this.label23.TabIndex = 0;
            this.label23.Text = "Cadastro de produto";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(348, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 31);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "&OK";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(450, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 31);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(447, 96);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 14;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(1, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 44);
            this.panel1.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Unidade";
            // 
            // cbxUnidade
            // 
            this.cbxUnidade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUnidade.FormattingEnabled = true;
            this.cbxUnidade.Items.AddRange(new object[] {
            "PROCESSADORES",
            "PLACA-MÃE",
            "PLACA DE VÍDEO",
            "PLACA DE SOM",
            "FONTE DE ALIMENTAÇÃO",
            "MEMÓRIA RAM",
            "DISCO RIGÍDO",
            "GABINETE",
            "MONITOR",
            "TECLADO",
            "MOUSE",
            "CAIXA DE SOM",
            "PEN-DRIVE",
            "HD EXTERNO",
            "LEITOR DVD/CD",
            "OUTROS"});
            this.cbxUnidade.Location = new System.Drawing.Point(227, 186);
            this.cbxUnidade.Name = "cbxUnidade";
            this.cbxUnidade.Size = new System.Drawing.Size(192, 21);
            this.cbxUnidade.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Grupo";
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Items.AddRange(new object[] {
            "PROCESSADORES",
            "PLACA-MÃE",
            "PLACA DE VÍDEO",
            "PLACA DE SOM",
            "FONTE DE ALIMENTAÇÃO",
            "MEMÓRIA RAM",
            "DISCO RIGÍDO",
            "GABINETE",
            "MONITOR",
            "TECLADO",
            "MOUSE",
            "CAIXA DE SOM",
            "PEN-DRIVE",
            "HD EXTERNO",
            "LEITOR DVD/CD",
            "OUTROS"});
            this.cbxGrupo.Location = new System.Drawing.Point(6, 186);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(192, 21);
            this.cbxGrupo.TabIndex = 17;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(6, 139);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(55, 20);
            this.txtEstoque.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Data de entrada";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Enabled = false;
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(419, 34);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(104, 20);
            this.dtpEntrada.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fornecedor";
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(337, 138);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(186, 21);
            this.cbxFornecedor.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Preço de venda";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(208, 138);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoVenda.TabIndex = 10;
            this.txtPrecoVenda.Leave += new System.EventHandler(this.txtPrecoVenda_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(93, 138);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 8;
            this.txtPreco.Leave += new System.EventHandler(this.txtPreco_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fabricante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estoque";
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxFabricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(337, 83);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(186, 21);
            this.cbxFabricante.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 83);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(302, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código de Barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCodigoBarras.Location = new System.Drawing.Point(6, 37);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoBarras.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 321);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.cbxUnidade);
            this.tabPage1.Controls.Add(this.cbxGrupo);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtCodigoBarras);
            this.tabPage1.Controls.Add(this.dtpEntrada);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtEstoque);
            this.tabPage1.Controls.Add(this.txtDescricao);
            this.tabPage1.Controls.Add(this.cbxFabricante);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbxFornecedor);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtPreco);
            this.tabPage1.Controls.Add(this.txtPrecoVenda);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FormCadastroProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(559, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCadastroProd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chronOS: Produto";
            this.Load += new System.EventHandler(this.FormCadastroProd_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFabricante;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxUnidade;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}