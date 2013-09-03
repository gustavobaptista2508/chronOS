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
    public class ProdutoService
    {
        public static string Message;
        public static bool Inserir(ProdutoModel Obj)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO Produto (Descricao, Fabricante, NumEstoque, Grupo, Codigo, CodigoBarras, Preco, Unidade, PrecoVenda, Fornecedor, DataEntrada) ");
            sql.Append("VALUES (@Descricao, @Fabricante, @NumEstoque, @Grupo, @Codigo, @CodigoBarras, @Preco, @Unidade, @PrecoVenda, @Fornecedor, @DataEntrada)");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Descricao", Obj.Descricao);
            cmd.Parameters.AddWithValue("@Fabricante", Obj.Fabricante);
            cmd.Parameters.AddWithValue("@Codigo", Obj.Codigo);
            cmd.Parameters.AddWithValue("@NumEstoque", Obj.NumEstoque);
            cmd.Parameters.AddWithValue("@CodigoBarras", Obj.CodigoBarras);
            cmd.Parameters.AddWithValue("@Preco", Obj.Preco);
            cmd.Parameters.AddWithValue("@PrecoVenda", Obj.PrecoVenda);
            cmd.Parameters.AddWithValue("@Fornecedor", Obj.Fornecedor);
            cmd.Parameters.AddWithValue("@Unidade", Obj.Unidade);
            cmd.Parameters.AddWithValue("@DataEntrada", Obj.DataEntrada);
            cmd.Parameters.AddWithValue("@Grupo", Obj.Grupo);
            int afetados = -1;
            try
            {
                conn.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }
            return (afetados > 0);
        }

        public static bool Alterar(ProdutoModel Obj)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE FROM Produto (Descricao=@Descricao, Fabricante=@Fabricante, Grupo=@Grupo, NumEstoque=@NumEstoque, Codigo=@Codigo, CodigoBarras=@CodigoBarras, Preco=@Preco, Unidade=@Unidade, PrecoVenda=@PrecoVenda, Fornecedor=@Fornecedor, DataEntrada=@DataEntrada) WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", Obj.Id);
            cmd.Parameters.AddWithValue("@Descricao", Obj.Descricao);
            cmd.Parameters.AddWithValue("@Fabricante", Obj.Fabricante);
            cmd.Parameters.AddWithValue("@Codigo", Obj.Codigo);
            cmd.Parameters.AddWithValue("@NumEstoque", Obj.NumEstoque);
            cmd.Parameters.AddWithValue("@CodigoBarras", Obj.CodigoBarras);
            cmd.Parameters.AddWithValue("@Preco", Obj.Preco);
            cmd.Parameters.AddWithValue("@PrecoVenda", Obj.PrecoVenda);
            cmd.Parameters.AddWithValue("@Fornecedor", Obj.Fornecedor);
            cmd.Parameters.AddWithValue("@Unidade", Obj.Unidade);
            cmd.Parameters.AddWithValue("@DataEntrada", Obj.DataEntrada);
            cmd.Parameters.AddWithValue("@Grupo", Obj.Grupo);
            int afetados = -1;
            try
            {
                conn.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            catch
            {
               
            }
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
            sql.Append("DELETE FROM Produto WHERE Id=@Id");
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

        public static ProdutoModel ObterPorId(int id)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Descricao, Fabricante, Codigo, NumEstoque, Grupo, CodigoBarras, Preco, Unidade, PrecoVenda, Fornecedor, DataEntrada FROM Produto WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", id);
            ProdutoModel obj = new ProdutoModel();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Descricao = leitor["Descricao"].ToString();
                        obj.Fabricante = leitor["Fabricante"].ToString();
                        obj.Codigo = leitor["Codigo"].ToString();
                        obj.CodigoBarras = leitor["CodigoBarras"].ToString();
                        obj.Preco = leitor["Preco"].ToString();
                        obj.NumEstoque = Convert.ToInt32(leitor["NumEstoque"]);
                        obj.PrecoVenda = leitor["PrecoVenda"].ToString();
                        obj.Unidade = leitor["Unidade"].ToString();
                        obj.Fornecedor = leitor["Fornecedor"].ToString();
                        obj.DataEntrada = Convert.ToDateTime(leitor["DataEntrada"]);
                        obj.Grupo = leitor["Grupo"].ToString();
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
            return obj;
        }

        public static List<ProdutoModel> ObterLista()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Descricao, Fabricante, Codigo, Grupo, NumEstoque, CodigoBarras, Preco, Unidade, PrecoVenda, Fornecedor, DataEntrada FROM Produto");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            List<ProdutoModel> lista = new List<ProdutoModel>();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        ProdutoModel obj = new ProdutoModel();
                        obj.Id=Convert.ToInt32(leitor["Id"]);
                        obj.Descricao = leitor["Descricao"].ToString();
                        obj.Fabricante = leitor["Fabricante"].ToString();
                        obj.Codigo = leitor["Codigo"].ToString();
                        obj.CodigoBarras = leitor["CodigoBarras"].ToString();
                        obj.NumEstoque = Convert.ToInt32(leitor["NumEstoque"]);
                        obj.Preco = leitor["Preco"].ToString();
                        obj.PrecoVenda = leitor["PrecoVenda"].ToString();
                        obj.Unidade = leitor["Unidade"].ToString();
                        obj.Fornecedor = leitor["Fornecedor"].ToString();
                        obj.DataEntrada = Convert.ToDateTime(leitor["DataEntrada"]);
                        obj.Grupo = leitor["Grupo"].ToString();
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

    }
}
