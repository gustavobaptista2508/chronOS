namespace Chronos
{
    partial class FormCadastroFunc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.cbxFuncao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpAdmissao = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(288, 103);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 14);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(327, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Location = new System.Drawing.Point(644, 105);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckbAtivo.TabIndex = 13;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // cbxFuncao
            // 
            this.cbxFuncao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFuncao.FormattingEnabled = true;
            this.cbxFuncao.Location = new System.Drawing.Point(67, 96);
            this.cbxFuncao.Name = "cbxFuncao";
            this.cbxFuncao.Size = new System.Drawing.Size(327, 21);
            this.cbxFuncao.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Função:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(501, 14);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 2;
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "RG:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(47, 52);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 20);
            this.txtRg.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(233, 52);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(409, 52);
            this.txtCelular.Mask = "(99) 0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 5;
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(480, 103);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(96, 20);
            this.dtpDataCadastro.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Data cadastro:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(442, 174);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(51, 21);
            this.cbxEstado.TabIndex = 12;
            this.cbxEstado.SelectedValueChanged += new System.EventHandler(this.cbxEstado_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(420, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "UF:";
            // 
            // cbxCidade
            // 
            this.cbxCidade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(208, 174);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(199, 21);
            this.cbxCidade.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(159, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Cidade:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(55, 174);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(80, 20);
            this.txtCep.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "CEP:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(469, 138);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(199, 20);
            this.txtBairro.TabIndex = 9;
            this.txtBairro.Leave += new System.EventHandler(this.txtBairro_Leave);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(86, 138);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(308, 20);
            this.txtEndereco.TabIndex = 8;
            this.txtEndereco.Leave += new System.EventHandler(this.txtEndereco_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(420, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Logradouro:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(422, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Data admissão:";
            // 
            // dtpAdmissao
            // 
            this.dtpAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdmissao.Location = new System.Drawing.Point(508, 96);
            this.dtpAdmissao.Name = "dtpAdmissao";
            this.dtpAdmissao.Size = new System.Drawing.Size(96, 20);
            this.dtpAdmissao.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(615, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 29);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(518, 14);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 29);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "&OK";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(0, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 57);
            this.panel1.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(496, 32);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(217, 26);
            this.label23.TabIndex = 0;
            this.label23.Text = "Cadastro de funcionário";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label23);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 68);
            this.panel2.TabIndex = 24;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 264);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbxEstado);
            this.tabPage1.Controls.Add(this.cbxFuncao);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbxCidade);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtCep);
            this.tabPage1.Controls.Add(this.txtTelefone);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(this.txtCelular);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.dtpAdmissao);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtRg);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtCpf);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(698, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FormCadastroFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(721, 439);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDataCadastro);
            this.Controls.Add(this.ckbAtivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCadastroFunc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chronOS: Funcionário";
            this.Load += new System.EventHandler(this.FormCadastroFunc_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.ComboBox cbxFuncao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpAdmissao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}