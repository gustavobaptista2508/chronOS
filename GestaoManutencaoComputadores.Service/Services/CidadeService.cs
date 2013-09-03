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
    public class CidadeService
    {
        public static List<CidadeModel> ObterLista()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Cidade.Id, Cidade.Nome, Estado.UF ");
            sql.Append("FROM Cidade INNER JOIN Estado ON Cidade.EstadoId = Estado.Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            List<CidadeModel> lista = new List<CidadeModel>();
            try
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        CidadeModel obj = new CidadeModel();
                        obj.Estado = new EstadoModel();
                        obj.Id = Convert.ToInt32(rdr["Id"]);
                        obj.Nome = rdr["Nome"].ToString();
                        obj.Estado.Uf = rdr["UF"].ToString();
                        lista.Add(obj);
                    }
                }
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }

            return lista;
        }

        public static List<CidadeModel> ObterListaPorId(int id)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Nome ");
            sql.Append("FROM Cidade WHERE EstadoId=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", id);
            List<CidadeModel> lista = new List<CidadeModel>();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        CidadeModel obj = new CidadeModel();
                        obj.Estado = new EstadoModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Nome = leitor["Nome"].ToString();
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

        public static CidadeModel ObterPorId(int id)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Nome, EstadoId ");
            sql.Append("FROM Cidade WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", id);
            CidadeModel obj = new CidadeModel();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        obj.Estado = new EstadoModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Nome = leitor["Nome"].ToString();
                        obj.Estado.Id = Convert.ToInt32(leitor["Id"]);
                    }
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return obj;
        }
    }
}
