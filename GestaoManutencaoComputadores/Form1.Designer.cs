namespace GestaoManutencaoComputadores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsTxtUsuario = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.equipamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelUsuario = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garantiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            this.tspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Chronos¹ continua em execução.";
            this.notifyIcon1.BalloonTipTitle = "Chronos¹ - Informação";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsTxtUsuario,
            this.toolStripSeparator4,
            this.equipamentoToolStripMenuItem,
            this.oSToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 145);
            // 
            // cmsTxtUsuario
            // 
            this.cmsTxtUsuario.Name = "cmsTxtUsuario";
            this.cmsTxtUsuario.Size = new System.Drawing.Size(100, 23);
            this.cmsTxtUsuario.Text = "Usuário";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // equipamentoToolStripMenuItem
            // 
            this.equipamentoToolStripMenuItem.Image = global::Chronos.Properties.Resources._1371072641_Computer;
            this.equipamentoToolStripMenuItem.Name = "equipamentoToolStripMenuItem";
            this.equipamentoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.equipamentoToolStripMenuItem.Text = "Equipamento";
            // 
            // oSToolStripMenuItem
            // 
            this.oSToolStripMenuItem.Image = global::Chronos.Properties.Resources._1367949193_onebit_39;
            this.oSToolStripMenuItem.Name = "oSToolStripMenuItem";
            this.oSToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.oSToolStripMenuItem.Text = "OS";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::Chronos.Properties.Resources._1370979815_user_64;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Image = global::Chronos.Properties.Resources._1370979962_user_group;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::Chronos.Properties.Resources._1371072823_MB__shut_down;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tspMenu
            // 
            this.tspMenu.BackColor = System.Drawing.SystemColors.Control;
            this.tspMenu.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelUsuario,
            this.toolStripSeparator1,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.tspMenu.Location = new System.Drawing.Point(0, 0);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.Padding = new System.Windows.Forms.Padding(2);
            this.tspMenu.Size = new System.Drawing.Size(1350, 52);
            this.tspMenu.TabIndex = 7;
            this.tspMenu.Text = "toolStrip1";
            // 
            // toolStripLabelUsuario
            // 
            this.toolStripLabelUsuario.Image = global::Chronos.Properties.Resources._1363803296_User;
            this.toolStripLabelUsuario.Name = "toolStripLabelUsuario";
            this.toolStripLabelUsuario.Size = new System.Drawing.Size(78, 45);
            this.toolStripLabelUsuario.Text = "Ususário";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::Chronos.Properties.Resources._1371072641_Computer;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(82, 45);
            this.toolStripButton6.Text = "Equipamento";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click_1);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.peçasToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.garantiaToolStripMenuItem});
            this.toolStripButton4.Image = global::Chronos.Properties.Resources._1371072747_redhat_system_tools;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(66, 45);
            this.toolStripButton4.Text = "Gerência";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Image = global::Chronos.Properties.Resources._1367440238_employee_user;
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(162, 32);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click_1);
            // 
            // peçasToolStripMenuItem
            // 
            this.peçasToolStripMenuItem.Image = global::Chronos.Properties.Resources._1371073677_hardware;
            this.peçasToolStripMenuItem.Name = "peçasToolStripMenuItem";
            this.peçasToolStripMenuItem.Size = new System.Drawing.Size(162, 32);
            this.peçasToolStripMenuItem.Text = "Peças";
            this.peçasToolStripMenuItem.Click += new System.EventHandler(this.peçasToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Image = global::Chronos.Properties.Resources._1371072701_Application;
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(162, 32);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click_1);
            // 
            // garantiaToolStripMenuItem
            // 
            this.garantiaToolStripMenuItem.Image = global::Chronos.Properties.Resources._1371073878_invoice;
            this.garantiaToolStripMenuItem.Name = "garantiaToolStripMenuItem";
            this.garantiaToolStripMenuItem.Size = new System.Drawing.Size(162, 32);
            this.garantiaToolStripMenuItem.Text = "Garantia";
            this.garantiaToolStripMenuItem.Click += new System.EventHandler(this.garantiaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::Chronos.Properties.Resources._1367949193_onebit_39;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(30, 45);
            this.toolStripButton5.Text = "OS";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.ToolTipText = "Ordens de Serviço";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Chronos.Properties.Resources._1370979815_user_64;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 45);
            this.toolStripButton1.Text = "Clientes";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::Chronos.Properties.Resources._1370979962_user_group;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(56, 45);
            this.toolStripButton3.Text = "Usuários";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Chronos.Properties.Resources._1367446289_iEngrenages;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(88, 45);
            this.toolStripButton2.Text = "Configurações";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::Chronos.Properties.Resources._1374692405_TechnicalSupportRepresentative_Male_Light;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(81, 45);
            this.toolStripButton7.Text = "Atendimento";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tspMenu);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chronos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox cmsTxtUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem equipamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripLabel toolStripLabelUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garantiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
    }
}

