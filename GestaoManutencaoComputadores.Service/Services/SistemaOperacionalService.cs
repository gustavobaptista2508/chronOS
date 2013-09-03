using Chronos.Service.Models;
using GestaoManutencaoComputadores.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Service.Services
{
    public class SistemaOperacionalService
    {
        public static List<SistemaOperacionalModel> ObterLista()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, NomeSistema, Desenvolvedora, Versao ");
            sql.Append("FROM Sistema");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            List<SistemaOperacionalModel> lista = new List<SistemaOperacionalModel>();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        SistemaOperacionalModel obj = new SistemaOperacionalModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.SistemaOperacional = leitor["NomeSistema"].ToString();
                        obj.Desenvolvedora = leitor["Desenvolvedora"].ToString();
                        obj.Versao = leitor["Versao"].ToString();
                        lista.Add(obj);
                    }
                    leitor.Dispose();
                    leitor.Close();
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return lista;
        }
    }
}
