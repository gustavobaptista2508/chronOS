using GestaoManutencaoComputadores.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.ObterConexao();
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("BACKUP database bdSecundario to disk='C:\\Servidor\\Backup\\bdSecundario_Backup_"+DateTime.Now.ToString("dd_MM_yyyy")+".bak'");
                    SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
                    cmd.ExecuteReader();
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
