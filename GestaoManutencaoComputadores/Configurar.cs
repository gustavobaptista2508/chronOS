using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoManutencaoComputadores.Service;
using System.IO;
using System.Data.SqlClient;
using Chronos;

namespace GestaoManutencaoComputadores
{
    public partial class Configurar : Form
    {
        public Configurar()
        {
            InitializeComponent();
            
        }

        private void Configurar_Load(object sender, EventArgs e)
        {
        }

        //private void popularTreeView()
        //{
        //    SqlConnection conexaoSQLServer=null;
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    DataSet ds = new DataSet();

        //    string sqlConsulta = "SELECT TABLE_NAME, COLUMN_NAME " +
        //    "FROM information_schema.columns " +
        //    "ORDER BY TABLE_NAME, COLUMN_NAME";

        //    TreeNode NoRaiz = null;
        //    TreeNode NoPrincipal = null;
        //    TreeNode NoFilho = null;

        //    string nomePrincipal = string.Empty;
        //    string nomeFilho = string.Empty;
        //    string BancoDados = DBSQLServer;

        //    try
        //    {
        //        conexaoSQLServer = Conexao.ObterConexao();
        //        conexaoSQLServer.Open();
        //        SqlCommand cmd = new SqlCommand(sqlConsulta, conexaoSQLServer);
        //        da.SelectCommand = cmd;
        //        da.Fill(ds, "Dados_Sistema");
        //        trvDados.Nodes.Clear();
        //        NoRaiz = trvDados.Nodes.Add(key: "Root", text: BancoDados, imageIndex: 0, selectedImageIndex: 0);
        //        int contaTabelas = 0;
        //        foreach (DataRow row in ds.Tables["Dados_Sistema"].Rows)
        //        {
        //            if (nomePrincipal != row[0].ToString())
        //            {
        //                NoPrincipal = NoRaiz.Nodes.Add(key: "Table", text: row[0].ToString(), imageIndex: 1, selectedImageIndex: 1);
        //                nomePrincipal = row[0].ToString();
        //                contaTabelas++;
        //            }

        //            NoFilho = NoPrincipal.Nodes.Add(key: "Column", text: row[1].ToString(), imageIndex: 2, selectedImageIndex: 2);
        //        }

        //        lblTabelas.Text = contaTabelas.ToString() + " Nº de tabelas";
        //        trvDados.Nodes[0].EnsureVisible();
        //    }
        //    catch (Exception erro)
        //    {
        //        MessageBox.Show(erro.Message);
        //        return;
        //    }
        //    finally
        //    {
        //        conexaoSQLServer.Close();
        //        conexaoSQLServer.Dispose();
        //        conexaoSQLServer = null;
        //    }
        //}
    }
}
