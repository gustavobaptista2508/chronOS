using GestaoManutencaoComputadores.Service.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoManutencaoComputadores.Service.Services
{
    public class PerfilServices
    {
        public static PerfilModel ObterPorId(int id)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Perfil ");
            sql.Append("FROM Perfil WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", id);
            PerfilModel obj = new PerfilModel();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if(leitor.HasRows)
                {
                    while(leitor.Read())
                    {
                        obj.Id= Convert.ToInt32(leitor["Id"]);
                        obj.Perfil = leitor["Perfil"].ToString();
                    }
                }
            }
            catch
            {}
            finally
            {conn.Close();}
            return obj;
        }

        public static List<PerfilModel> ObterListaPorId(int id)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Perfil ");
            sql.Append("FROM Perfil");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", id);
            List<PerfilModel> lista = new List<PerfilModel>();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        PerfilModel obj = new PerfilModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Perfil = leitor["Perfil"].ToString();
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

        public static List<PerfilModel> ObterLista()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Perfil ");
            sql.Append("FROM Perfil");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            List<PerfilModel> lista = new List<PerfilModel>();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        PerfilModel obj = new PerfilModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Perfil = leitor["Perfil"].ToString();
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
