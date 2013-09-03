namespace Chronos
{
    partial class FormConfigurar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigurar));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbtnConexaoRemota = new System.Windows.Forms.RadioButton();
            this.rbtnLocal = new System.Windows.Forms.RadioButton();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.cbxConexoes = new System.Windows.Forms.ComboBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuarioServer = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtSenhaServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Chronos.Properties.Resources.Imagem1;
            this.splitContainer1.Panel1.Controls.Add(this.btnAjuda);
            this.splitContainer1.Panel1.Controls.Add(this.btnSair);
            this.splitContainer1.Panel1.Controls.Add(this.lblLogin);
            this.splitContainer1.Panel1.Controls.Add(this.lblPerfil);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblNome);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.shapeContainer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(644, 480);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjuda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjuda.Image = global::Chronos.Properties.Resources._1375058686_restart_1;
            this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.Location = new System.Drawing.Point(12, 126);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(100, 49);
            this.btnAjuda.TabIndex = 0;
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
            this.btnSair.Image = global::Chronos.Properties.Resources._1375479778_exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 181);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 49);
            this.btnSair.TabIndex = 2;
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
            this.lblLogin.Location = new System.Drawing.Point(83, 77);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(70, 13);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login usuário";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPerfil.Location = new System.Drawing.Point(83, 60);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(67, 13);
            this.lblPerfil.TabIndex = 3;
            this.lblPerfil.Text = "Perfil usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(82, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configurações";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Location = new System.Drawing.Point(83, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(87, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do usuário";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Chronos.Properties.Resources._1370979815_user_64;
            this.pictureBox2.Location = new System.Drawing.Point(11, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 62);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(268, 478);
            this.shapeContainer1.TabIndex = 7;
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
            this.tabControl1.Location = new System.Drawing.Point(7, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 447);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbtnConexaoRemota);
            this.tabPage1.Controls.Add(this.rbtnLocal);
            this.tabPage1.Controls.Add(this.txtNomeBanco);
            this.tabPage1.Controls.Add(this.cbxConexoes);
            this.tabPage1.Controls.Add(this.btnTestConnection);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtUsuarioServer);
            this.tabPage1.Controls.Add(this.btnGravar);
            this.tabPage1.Controls.Add(this.txtSenhaServer);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Banco de dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbtnConexaoRemota
            // 
            this.rbtnConexaoRemota.AutoSize = true;
            this.rbtnConexaoRemota.Location = new System.Drawing.Point(115, 44);
            this.rbtnConexaoRemota.Name = "rbtnConexaoRemota";
            this.rbtnConexaoRemota.Size = new System.Drawing.Size(104, 17);
            this.rbtnConexaoRemota.TabIndex = 14;
            this.rbtnConexaoRemota.TabStop = true;
            this.rbtnConexaoRemota.Text = "Servidor Remoto";
            this.rbtnConexaoRemota.UseVisualStyleBackColor = true;
            this.rbtnConexaoRemota.CheckedChanged += new System.EventHandler(this.rbtnConexaoRemota_CheckedChanged);
            // 
            // rbtnLocal
            // 
            this.rbtnLocal.AutoSize = true;
            this.rbtnLocal.Location = new System.Drawing.Point(10, 44);
            this.rbtnLocal.Name = "rbtnLocal";
            this.rbtnLocal.Size = new System.Drawing.Size(73, 17);
            this.rbtnLocal.TabIndex = 13;
            this.rbtnLocal.TabStop = true;
            this.rbtnLocal.Text = "(localhost)";
            this.rbtnLocal.UseVisualStyleBackColor = true;
            this.rbtnLocal.CheckedChanged += new System.EventHandler(this.rbtnLocal_CheckedChanged);
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(6, 236);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(206, 20);
            this.txtNomeBanco.TabIndex = 7;
            this.txtNomeBanco.Leave += new System.EventHandler(this.txtNomeBanco_Leave);
            // 
            // cbxConexoes
            // 
            this.cbxConexoes.FormattingEnabled = true;
            this.cbxConexoes.Location = new System.Drawing.Point(6, 86);
            this.cbxConexoes.Name = "cbxConexoes";
            this.cbxConexoes.Size = new System.Drawing.Size(206, 21);
            this.cbxConexoes.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cbxConexoes, "Selecione o servidor que se encontre disponível abaixo");
            this.cbxConexoes.SelectedValueChanged += new System.EventHandler(this.cbxConexoes_SelectedValueChanged);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(100, 270);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(112, 23);
            this.btnTestConnection.TabIndex = 11;
            this.btnTestConnection.Text = "Testar conexão";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Selecione o tipo de conexão";
            // 
            // txtUsuarioServer
            // 
            this.txtUsuarioServer.Location = new System.Drawing.Point(6, 138);
            this.txtUsuarioServer.Name = "txtUsuarioServer";
            this.txtUsuarioServer.Size = new System.Drawing.Size(206, 20);
            this.txtUsuarioServer.TabIndex = 2;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(6, 270);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "&OK";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSenhaServer
            // 
            this.txtSenhaServer.Location = new System.Drawing.Point(6, 187);
            this.txtSenhaServer.Name = "txtSenhaServer";
            this.txtSenhaServer.Size = new System.Drawing.Size(206, 20);
            this.txtSenhaServer.TabIndex = 3;
            this.txtSenhaServer.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome do banco de dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome ou endereço TCP/IP do servidor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuário do servidor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(644, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informações";
            // 
            // FormConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 502);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConfigurar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chronOS: Configurar";
            this.Load += new System.EventHandler(this.FormConfigurar_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaServer;
        private System.Windows.Forms.TextBox txtUsuarioServer;
        private System.Windows.Forms.ComboBox cbxConexoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeBanco;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.RadioButton rbtnConexaoRemota;
        private System.Windows.Forms.RadioButton rbtnLocal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}