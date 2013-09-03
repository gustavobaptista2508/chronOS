using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Chronos.Service;
using GestaoManutencaoComputadores.Service;

namespace Chronos
{
    public class Preencher
    {

        public static string PreecherCpf(string nome)
        {
            string cpf = "";
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Cpf FROM Cliente WHERE Nome=@Nome");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Nome", nome);
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    cpf = leitor["Cpf"].ToString();
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return cpf;
        }

        public static string PreecherRg(string nome)
        {
            string rg = "";
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Rg FROM Cliente WHERE Nome=@Nome");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Nome", nome);
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    rg = leitor["Rg"].ToString();
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return rg;
        }

        public static string PreecherTelefone(string nome)
        {
            string telefone = "";
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Telefone FROM Cliente WHERE Nome=@Nome");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Nome", nome);
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    telefone = leitor["Telefone"].ToString();
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return telefone;
        }

        public static string PreecherCelular(string nome)
        {
            string celular = "";
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Celular FROM Cliente WHERE Nome=@Nome");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Nome", nome);
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    celular = leitor["Celular"].ToString();
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return celular;
        }

        public static string PreecherEndereco(string nome)
        {
            string endereco = "";
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Endereco FROM Cliente WHERE Nome=@Nome");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Nome", nome);
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    endereco = leitor["Endereco"].ToString();
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return endereco;
        }

        public static string PreecherBairro(string nome)
        {
            string bairro = "";
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Bairro FROM Cliente WHERE Nome=@Nome");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Nome", nome);
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    bairro = leitor["Bairro"].ToString();
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return bairro;
        }

        public static string PreecherCidade(string nome)
        {
            string cidade = "";
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Cidade FROM Cliente WHERE Nome=@Nome");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Nome", nome);
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    cidade = leitor["Cidade"].ToString();
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return cidade;
        }

        public static string PreecherCep(string nome)
        {
            string cep = "";
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Cep FROM Cliente WHERE Nome=@Nome");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Nome", nome);
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    cep = leitor["Cep"].ToString();
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return cep;
        }

        public static string PreecherEstado(string nome)
        {
            string estado = "";
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Estado FROM Cliente WHERE Nome=@Nome");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Nome", nome);
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    estado = leitor["Estado"].ToString();
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
            return estado;
        }
    }
}
