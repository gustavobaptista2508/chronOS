using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chronos.Service.Models;
using System.Data.SqlClient;

namespace GestaoManutencaoComputadores.Service.Models
{
    public class FuncionarioService
    {
        public static bool Inserir(FuncionarioModel Obj)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO Funcionario (Nome, DataAdmissao, DataCadastro, Codigo, Cpf, Rg, Celular, Telefone, Endereco, Cidade, Bairro, Cep, Estado, Ativo, IdFuncao) ");
            sql.Append("VALUES (@Nome, @DataAdmissao, @DataCadastro, @Codigo, @Cpf, @Rg, @Celular, @Telefone, @Endereco, @Cidade, @Bairro, @Cep, @Estado, @Ativo, @IdFuncao)");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Nome", Obj.Nome);
            cmd.Parameters.AddWithValue("@Cpf", Obj.Cpf);
            cmd.Parameters.AddWithValue("@Rg", Obj.Rg);
            cmd.Parameters.AddWithValue("@Codigo", Obj.Codigo);
            cmd.Parameters.AddWithValue("@DataAdmissao", Obj.DataAdmissao);
            cmd.Parameters.AddWithValue("@DataCadastro", Obj.DataCadastro);
            cmd.Parameters.AddWithValue("@Celular", Obj.Celular);
            cmd.Parameters.AddWithValue("@Telefone", Obj.Telefone);
            cmd.Parameters.AddWithValue("@Endereco", Obj.Endereco);
            cmd.Parameters.AddWithValue("@Cidade", Obj.Cidade);
            cmd.Parameters.AddWithValue("@Bairro", Obj.Bairro);
            cmd.Parameters.AddWithValue("@Cep", Obj.Cep);
            cmd.Parameters.AddWithValue("@Estado", Obj.Estado);
            cmd.Parameters.AddWithValue("@Ativo", Obj.Ativo);
            cmd.Parameters.AddWithValue("@IdFuncao", Obj.Funcao.Id);
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

        public static bool Alterar(FuncionarioModel Obj)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE Funcionario SET Nome=@Nome, Cpf=@Cpf, Rg=@Rg, Telefone=@Telefone, Celular=@Celular, Endereco=@Endereco, Bairro=@Bairro, Cep=@Cep, Cidade=@Cidade, Estado=@Estado, DataCadastro=@DataCadastro, DataAdmissao=@DataAdmissao, Ativo=@Ativo, IdFuncao=@IdFuncao ");
            sql.Append("WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", Obj.Id);
            cmd.Parameters.AddWithValue("@Nome", Obj.Nome);
            cmd.Parameters.AddWithValue("@Cpf", Obj.Cpf);
            cmd.Parameters.AddWithValue("@Rg", Obj.Rg);
            cmd.Parameters.AddWithValue("@Telefone", Obj.Telefone);
            cmd.Parameters.AddWithValue("@Celular", Obj.Celular);
            cmd.Parameters.AddWithValue("@Endereco", Obj.Endereco);
            cmd.Parameters.AddWithValue("@Bairro", Obj.Bairro);
            cmd.Parameters.AddWithValue("@Cep", Obj.Cep);
            cmd.Parameters.AddWithValue("@Cidade", Obj.Cidade);
            cmd.Parameters.AddWithValue("@Estado", Obj.Estado);
            cmd.Parameters.AddWithValue("@DataCadastro", Obj.DataCadastro);
            cmd.Parameters.AddWithValue("@DataAdmissao", Obj.DataAdmissao);
            cmd.Parameters.AddWithValue("@Ativo", Obj.Ativo);
            cmd.Parameters.AddWithValue("@IdFuncao", Obj.Funcao.Id);
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
            sql.Append("DELETE FROM Funcionario ");
            sql.Append("WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", keys[0]);
            int afetados = -1;
            try
            {
                conn.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return (afetados > 0);
        }

        public static FuncionarioModel ObterPorId(int id)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Nome, Cpf, Rg, Estado, Codigo, Celular, DataCadastro, Telefone, Cidade, Endereco, Bairro, Cep, DataAdmissao, Ativo, IdFuncao ");
            sql.Append("FROM Funcionario WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", id);
            FuncionarioModel obj = new FuncionarioModel();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        obj.Funcao = new FuncaoModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Nome = leitor["Nome"].ToString();
                        obj.Cpf = leitor["Cpf"].ToString();
                        obj.Rg = leitor["Rg"].ToString();
                        obj.Celular = leitor["Celular"].ToString();
                        obj.Telefone = leitor["Telefone"].ToString();
                        obj.Endereco = leitor["Endereco"].ToString();
                        obj.Bairro = leitor["Bairro"].ToString();
                        obj.Estado = leitor["Estado"].ToString();
                        obj.Cidade = leitor["Cidade"].ToString();
                        obj.Cep = leitor["Cep"].ToString();
                        obj.Codigo = Convert.ToInt32(leitor["Codigo"]);
                        obj.DataAdmissao = Convert.ToDateTime(leitor["DataAdmissao"]);
                        obj.DataCadastro = Convert.ToDateTime(leitor["DataCadastro"]);
                        obj.Funcao.Id = Convert.ToInt32(leitor["IdFuncao"]);
                        obj.Ativo = Convert.ToBoolean(leitor["Ativo"]);
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

        public static List<FuncionarioModel> ObterLista()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Funcionario.Id, Funcionario.Nome, Funcionario.Cpf, Funcionario.Rg, Funcionario.Estado, Funcionario.Codigo, Funcionario.Celular, Funcionario.DataCadastro, Funcionario.Telefone, Funcionario.Cidade, Funcionario.Endereco, Funcionario.Bairro, Funcionario.Cep, Funcionario.DataAdmissao, Funcionario.Ativo, Funcao.Funcao ");
            sql.Append("FROM Funcionario INNER JOIN Funcao ON Funcionario.IdFuncao = Funcao.Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            List<FuncionarioModel> lista = new List<FuncionarioModel>();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                   while (leitor.Read())
                    {
                        FuncionarioModel obj = new FuncionarioModel();
                        obj.Funcao = new FuncaoModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Nome = leitor["Nome"].ToString();
                        obj.Cpf = leitor["Cpf"].ToString();
                        obj.Rg = leitor["Rg"].ToString();
                        obj.Celular = leitor["Celular"].ToString();
                        obj.Telefone = leitor["Telefone"].ToString();
                        obj.Endereco = leitor["Endereco"].ToString();
                        obj.Bairro = leitor["Bairro"].ToString();
                        obj.Estado = leitor["Estado"].ToString();
                        obj.Cidade = leitor["Cidade"].ToString();
                        obj.Cep = leitor["Cep"].ToString();
                        obj.Codigo = Convert.ToInt32(leitor["Codigo"]);
                        obj.DataAdmissao = Convert.ToDateTime(leitor["DataAdmissao"]);
                        obj.DataCadastro = Convert.ToDateTime(leitor["DataCadastro"]);
                        obj.Funcao.Funcao = leitor["Funcao"].ToString();
                        obj.Ativo = Convert.ToBoolean(leitor["Ativo"]);             
                        lista.Add(obj);
                    }
                }
            }
            catch
            {}
            finally
            {
                conn.Close();
            }
            return lista;
        }
    }
}
