using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoManutencaoComputadores.Service.Models;
using System.Data.SqlClient;
using Chronos.Service.Models;

namespace GestaoManutencaoComputadores.Service.Services
{
    public class UsuarioServices
    {
        public static bool Inserir(UsuarioModel Obj)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO Usuario (Usuario, Senha, IdPerfil, IdFuncionario, Ativo, Email) ");
            sql.Append("VALUES (@Usuario, @Senha, @IdPerfil, @IdFuncionario, @Ativo, @Email)");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Usuario", Obj.Login);
            cmd.Parameters.AddWithValue("@Senha", Obj.Senha);
            cmd.Parameters.AddWithValue("@IdFuncionario", Obj.Funcionario.Id);
            cmd.Parameters.AddWithValue("@Ativo", Obj.Ativo);          
            cmd.Parameters.AddWithValue("@IdPerfil", Obj.Perfil.Id);
            cmd.Parameters.AddWithValue("@Email", Obj.Email);
            int afetados = -1;
            try
            {
                conn.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return (afetados > 0);
        }

        public static bool Alterar(UsuarioModel Obj)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE Usuario SET Usuario='"+Obj.Login+"', Email='"+Obj.Email+"', Senha='"+Obj.Senha+"', IdPerfil="+Obj.Perfil.Id+", Ativo='"+Obj.Ativo+"', IdFuncionario="+Obj.Funcionario.Id+" ");
            sql.Append("WHERE Id="+Obj.Id);
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            int afetados = -1;
            try
            {
                conn.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return (afetados > 0);
        }

        public static bool Excluir(params object[] keys)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM Usuario ");
            sql.Append("WHERE Id="+keys[0]);
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            int afetados = -1;
            try
            {
                conn.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return (afetados > 0);
        }

        public static List<UsuarioModel> ObterLista()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Usuario.Id, Usuario.Usuario, Usuario.Email, Perfil.Perfil, Funcionario.Nome, Usuario.Ativo ");
            sql.Append("FROM Usuario INNER JOIN Perfil ON Perfil.Id=Usuario.IdPerfil INNER JOIN Funcionario ON Funcionario.Id=Usuario.IdFuncionario");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            List<UsuarioModel> lista = new List<UsuarioModel>();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        UsuarioModel obj = new UsuarioModel();
                        obj.Perfil = new PerfilModel();
                        obj.Funcionario = new FuncionarioModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Login = leitor["Usuario"].ToString();
                        obj.Perfil.Perfil = leitor["Perfil"].ToString();
                        obj.Funcionario.Nome = leitor["Nome"].ToString();
                        obj.Ativo = leitor["Ativo"].ToString();
                        obj.Email = leitor["Email"].ToString();
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

        public static UsuarioModel ObterPorId(int id)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Usuario, Senha, IdPerfil, IdFuncionario, Ativo, Email ");
            sql.Append("FROM Usuario WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", id);
            UsuarioModel obj = new UsuarioModel();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        obj.Perfil = new PerfilModel();
                        obj.Funcionario = new FuncionarioModel();
                        obj.Perfil.Id = Convert.ToInt32(leitor["IdPerfil"]);
                        obj.Funcionario.Id = Convert.ToInt32(leitor["IdFuncionario"]);
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Login = leitor["Usuario"].ToString();
                        obj.Senha = leitor["Senha"].ToString();
                        obj.Ativo = leitor["Ativo"].ToString();
                        obj.Email = leitor["Email"].ToString();
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
