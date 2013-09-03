using Chronos;
using IInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoManutencaoComputadores
{
    public partial class Form1 : Form
    {
        List<IListagem> Cadastros = new List<IListagem>();

        public Form1()
        {
            InitializeComponent();

            //---------------------------------------------------------------//
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "Plugins");
            foreach (FileInfo file in di.GetFiles("*.dll"))
            {
                System.Reflection.Assembly dllPlugin =
                    System.Reflection.Assembly.LoadFile(file.FullName);

                IListagem formListagem = (IListagem)dllPlugin.CreateInstance("UsandoPlugins.Cadastro.FormListagem",
                    false, //não ignora maiúsculas e minúsculas
                    BindingFlags.CreateInstance, //especifica que queremos chamar o construtor
                    null, //o associador (binder) padrão será usado
                    null, //o construtor não requer argumentos
                    null, //usa a cultura da thread padrão
                    null //sem atributos de ativação
                    );
                this.Cadastros.Add(formListagem);
            }
            toolStripButton2.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //GestaoManutencaoComputadores.Service.Conexao.CarregarConfig();
            //--------------------------------------------------------//
            foreach (var item in this.Cadastros)
            {
                Button btn = new Button();
                btn.Tag = item;
                btn.Text = item.ObterTituloMenu();
                btn.Height = 40;
                btn.Margin = new Padding(10);
                btn.Click += new EventHandler(btn_Click);
                this.tspMenu.Container.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            ((sender as Button).Tag as IListagem).Mostrar();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar Chronos¹?", " Chronos¹",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            FormListaClientes frm = new FormListaClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            FormUsuarios janelaUser = new FormUsuarios();
            janelaUser.MdiParent = this;
            janelaUser.Show();
        }

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
            FormEquipamentos janelaEquip = new FormEquipamentos();
            janelaEquip.MdiParent = this;
            janelaEquip.Show();
        }

        private void funcionáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormFuncionarios janelaFunc = new FormFuncionarios();
            janelaFunc.MdiParent = this;
            janelaFunc.Show();
        }

        private void peçasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serviçosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void garantiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
