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
    public class FuncaoService
    {
        public static List<FuncaoModel> ObterLista()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Funcao ");
            sql.Append("FROM Funcao");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            List<FuncaoModel> lista = new List<FuncaoModel>();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        FuncaoModel obj = new FuncaoModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Funcao = leitor["Funcao"].ToString();
                        lista.Add(obj);
                    }
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
