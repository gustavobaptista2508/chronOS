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
    public class EstadoService
    {
        public static List<EstadoModel> ObterLista()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Nome, UF ");
            sql.Append("FROM Estado");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            List<EstadoModel> lista = new List<EstadoModel>();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        EstadoModel obj = new EstadoModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Nome = leitor["Nome"].ToString();
                        obj.Uf = leitor["UF"].ToString();
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
