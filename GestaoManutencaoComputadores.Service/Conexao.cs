using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using Chronos.Service.Properties;
using Chronos.Service.Configurar;

namespace GestaoManutencaoComputadores.Service
{
    public class Conexao
    {
        public static string CaminhoConexao = Configuracoes.ObterConnectionString().ConnectionString.ToString();
        public static SqlConnection conexao; 

        public static SqlConnection ObterConexao()
        {
            if (conexao == null)
            {
                conexao = new SqlConnection(CaminhoConexao);
            }
            return conexao;
        }
    }
}
