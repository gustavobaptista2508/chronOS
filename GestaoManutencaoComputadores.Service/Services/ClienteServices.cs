using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoManutencaoComputadores.Service.Models;
using System.Data.SqlClient;

namespace GestaoManutencaoComputadores.Service.Services
{
    public class ClienteServices
    {
        public static bool Inserir(ClienteModel Obj)
        {
            SqlConnection conn = Conexao.ObterConexao();
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO Cliente (Nome, Email, DataCadastro, Endereco, Bairro, Cidade, Cep, Estado, Telefone, Celular, Cpf, Rg) ");
            sql.Append("VALUES (@Nome, @Email, @DataCadastro, @Endereco, @Bairro, @Cidade, @Cep, @Estado, @Telefone, @Celular, @Cpf, @Rg)");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Nome", Obj.Nome);
            cmd.Parameters.AddWithValue("@Email", Obj.Email);
            cmd.Parameters.AddWithValue("@Endereco", Obj.Endereco);
            cmd.Parameters.AddWithValue("@Bairro", Obj.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", Obj.Cidade);
            cmd.Parameters.AddWithValue("@Cep", Obj.Cep);
            cmd.Parameters.AddWithValue("@Estado", Obj.Estado);
            cmd.Parameters.AddWithValue("@Telefone", Obj.Telefone);
            cmd.Parameters.AddWithValue("@Celular", Obj.Celular);
            cmd.Parameters.AddWithValue("@Cpf", Obj.Cpf);
            cmd.Parameters.AddWithValue("@Rg", Obj.Rg);
            cmd.Parameters.AddWithValue("@DataCadastro", Obj.DataCadastro);
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

        public static bool Alterar(ClienteModel Obj)
        {
            SqlConnection conn = Conexao.ObterConexao();
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE Cliente SET Nome=@Nome, Email=@Email, DataCadastro=@DataCadastro, Endereco=@Endereco, Bairro=@Bairro, Cidade=@Cidade, Cep=@Cep, Estado=@Estado, Telefone=@Telefone, Celular=@Celular, Cpf=@Cpf, Rg=@Rg) ");
            sql.Append("WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", Obj.Id);
            cmd.Parameters.AddWithValue("@Nome", Obj.Nome);
            cmd.Parameters.AddWithValue("@Email", Obj.Email);
            cmd.Parameters.AddWithValue("@Endereco", Obj.Endereco);
            cmd.Parameters.AddWithValue("@Bairro", Obj.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", Obj.Cidade);
            cmd.Parameters.AddWithValue("@Cep", Obj.Cep);
            cmd.Parameters.AddWithValue("@Estado", Obj.Estado);
            cmd.Parameters.AddWithValue("@Telefone", Obj.Telefone);
            cmd.Parameters.AddWithValue("@Celular", Obj.Celular);
            cmd.Parameters.AddWithValue("@Cpf", Obj.Cpf);
            cmd.Parameters.AddWithValue("@Rg", Obj.Rg);
            cmd.Parameters.AddWithValue("@DataCadastro", Obj.DataCadastro);
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
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM Cliente ");
            sql.Append("WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", keys[0]);
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

        public static ClienteModel ObterPorId(int id)
        {
            SqlConnection conn = Conexao.ObterConexao();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Nome, Email, Endereco, DataCadastro, Bairro, Cidade, Cep, Estado, Telefone, Celular, Cpf, Rg ");
            sql.Append("FROM Cliente WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", id);
            ClienteModel obj = new ClienteModel();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Nome = leitor["Nome"].ToString();
                        obj.Email = leitor["Email"].ToString();
                        obj.Endereco = leitor["Endereco"].ToString();
                        obj.Bairro = leitor["Bairro"].ToString();
                        obj.Cidade = leitor["Cidade"].ToString();
                        obj.Cep = leitor["Cep"].ToString();
                        obj.Estado = leitor["Estado"].ToString();
                        obj.Telefone = leitor["Telefone"].ToString();
                        obj.Celular = leitor["Celular"].ToString();
                        obj.Cpf = leitor["Cpf"].ToString();
                        obj.Rg = leitor["Rg"].ToString();
                        obj.DataCadastro = Convert.ToDateTime(leitor["DataCadastro"]);
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

        public static List<ClienteModel> ObterLista()
        {
            SqlConnection conn = Conexao.ObterConexao();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Nome, Email, Endereco, DataCadastro, Bairro, Cidade, Cep, Estado, Telefone, Celular, Cpf, Rg ");
            sql.Append("FROM Cliente");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            List<ClienteModel> lista = new List<ClienteModel>();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        ClienteModel obj = new ClienteModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Nome = leitor["Nome"].ToString();
                        obj.Email = leitor["Email"].ToString();
                        obj.Endereco = leitor["Endereco"].ToString();
                        obj.Bairro = leitor["Bairro"].ToString();
                        obj.Cidade = leitor["Cidade"].ToString();
                        obj.Cep = leitor["Cep"].ToString();
                        obj.Estado = leitor["Estado"].ToString();
                        obj.Telefone = leitor["Telefone"].ToString();
                        obj.Celular = leitor["Celular"].ToString();
                        obj.Cpf = leitor["Cpf"].ToString();
                        obj.Rg = leitor["Rg"].ToString();
                        obj.DataCadastro = Convert.ToDateTime(leitor["DataCadastro"]);
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
