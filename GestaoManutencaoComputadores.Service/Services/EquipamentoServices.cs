using Chronos.Service.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoManutencaoComputadores.Service.Models
{
    public class EquipamentoServices
    {
        public static bool Inserir(EquipamentoModel Obj)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO Computador (Descricao, Fabricante, Modelo, IdCliente, Codigo, Tipo, NumSerie, PlacaMae, PlacaSom, PlacaVideo, DiscoRigido, MemoriaRam, Processador, IdSistema, DataEntrada, DataSaida) ");
            sql.Append("VALUES (@Descricao, @Fabricante, @Modelo, @IdCliente, @Codigo, @Tipo, @NumSerie, @PlacaMae, @PlacaSom, @PlacaVideo, @DiscoRigido, @MemoriaRam, @Processador, @IdSistema, @DataEntrada, @DataSaida)");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Descricao", Obj.Equipamento);
            cmd.Parameters.AddWithValue("@Fabricante", Obj.Fabricante);
            cmd.Parameters.AddWithValue("@Modelo", Obj.Modelo);
            cmd.Parameters.AddWithValue("@IdCliente", Obj.Cliente.Id);
            cmd.Parameters.AddWithValue("@Codigo", Obj.Codigo);
            cmd.Parameters.AddWithValue("@Tipo", Obj.Tipo);
            cmd.Parameters.AddWithValue("@NumSerie", Obj.NumSerie);
            cmd.Parameters.AddWithValue("@PlacaMae", Obj.PlacaMae);
            cmd.Parameters.AddWithValue("@PlacaSom", Obj.PlacaSom);
            cmd.Parameters.AddWithValue("@PlacaVideo", Obj.PlacaVideo);
            cmd.Parameters.AddWithValue("@DiscoRigido", Obj.DiscoRigido);
            cmd.Parameters.AddWithValue("@MemoriaRam", Obj.MemoriaRam);
            cmd.Parameters.AddWithValue("@Processador", Obj.Processador);
            cmd.Parameters.AddWithValue("@IdSistema", Obj.Sistema.Id);
            cmd.Parameters.AddWithValue("@DataEntrada", Obj.DataEntrada);
            cmd.Parameters.AddWithValue("@DataSaida", Obj.DataSaida);
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

        public static bool Alterar(EquipamentoModel Obj)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE Computador SET Descricao=@Descricao, Modelo=@Modelo, Fabricante=@Fabricante, IdCliente=@IdCliente, Codigo=@Codigo, Tipo=@Tipo, NumSerie=@NumSerie, PlacaMae=@PlacaMae, PlacaSom=@PlacaSom, PlacaVideo=@PlacaVideo, DiscoRigido=@DiscoRigido, MemoriaRam=@MemoriaRam, Processador=@Processador, IdSistema=@IdSistema, DataEntrada=@DataEntrada, DataSaida=@DataSaida ");
            sql.Append("WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", Obj.Id);
            cmd.Parameters.AddWithValue("@Descricao", Obj.Equipamento);
            cmd.Parameters.AddWithValue("@Fabricante", Obj.Fabricante);
            cmd.Parameters.AddWithValue("@Modelo", Obj.Modelo);
            cmd.Parameters.AddWithValue("@IdCliente", Obj.Cliente.Id);
            cmd.Parameters.AddWithValue("@Tipo", Obj.Tipo);
            cmd.Parameters.AddWithValue("@Codigo", Obj.Codigo);
            cmd.Parameters.AddWithValue("@NumSerie", Obj.NumSerie);
            cmd.Parameters.AddWithValue("@PlacaMae", Obj.PlacaMae);
            cmd.Parameters.AddWithValue("@PlacaSom", Obj.PlacaSom);
            cmd.Parameters.AddWithValue("@PlacaVideo", Obj.PlacaVideo);
            cmd.Parameters.AddWithValue("@DiscoRigido", Obj.DiscoRigido);
            cmd.Parameters.AddWithValue("@MemoriaRam", Obj.MemoriaRam);
            cmd.Parameters.AddWithValue("@Processador", Obj.Processador);
            cmd.Parameters.AddWithValue("@IdSistema", Obj.Sistema.Id);
            cmd.Parameters.AddWithValue("@DataEntrada", Obj.DataEntrada);
            cmd.Parameters.AddWithValue("@DataSaida", Obj.DataSaida);
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
            sql.Append("DELETE FROM Computador ");
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

        public static EquipamentoModel ObterPorId(int id)
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Descricao, Modelo, Fabricante, Tipo, Codigo, IdCliente, NumSerie, PlacaMae, PlacaSom, PlacaVideo, DiscoRigido, MemoriaRam, Processador, IdSistema, DataEntrada, DataSaida ");
            sql.Append("FROM Computador WHERE Id=@Id");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@Id", id);
            EquipamentoModel obj = new EquipamentoModel();
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        obj.Cliente = new ClienteModel();
                        obj.Sistema = new SistemaOperacionalModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Equipamento = leitor["Descricao"].ToString();
                        obj.Fabricante = leitor["Fabricante"].ToString();
                        obj.Modelo = leitor["Modelo"].ToString();
                        obj.Tipo = leitor["Tipo"].ToString();
                        obj.Cliente.Id = Convert.ToInt32(leitor["IdCliente"]);
                        obj.Codigo = leitor["Codigo"].ToString();
                        obj.NumSerie = leitor["NumSerie"].ToString();
                        obj.PlacaMae = leitor["PlacaMae"].ToString();
                        obj.PlacaSom = leitor["PlacaSom"].ToString();
                        obj.PlacaVideo = leitor["PlacaVideo"].ToString();
                        obj.MemoriaRam = leitor["MemoriaRam"].ToString();
                        obj.DiscoRigido = leitor["DiscoRigido"].ToString();
                        obj.Processador = leitor["Processador"].ToString();
                        obj.Sistema.Id = Convert.ToInt32(leitor["IdSistema"]);
                        obj.DataEntrada = Convert.ToDateTime(leitor["DataEntrada"]);
                        obj.DataSaida = Convert.ToDateTime(leitor["DataSaida"]);
                    }
                    leitor.Close();
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

        public static List<EquipamentoModel> ObterLista()
        {
            SqlConnection conn = Conexao.ObterConexao();
            if (conn.ConnectionString == "")
            {
                conn = new SqlConnection(Conexao.CaminhoConexao);
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Computador.Id, Computador.Descricao, Computador.Modelo, Computador.Fabricante, Computador.Tipo, Computador.Codigo, Computador.NumSerie, Computador.PlacaMae, Computador.PlacaSom, Computador.PlacaVideo, Computador.DiscoRigido, Computador.MemoriaRam, Computador.Processador, Computador.DataEntrada, Computador.DataSaida, Sistema.NomeSistema, Cliente.Nome, Cliente.Cpf, Cliente.Telefone ");
            sql.Append("FROM Computador INNER JOIN Sistema ON Computador.IdSistema = Sistema.Id INNER JOIN Cliente ON Cliente.Id = Computador.IdCliente");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            List<EquipamentoModel> lista = new List<EquipamentoModel>();
            try 
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while(leitor.Read())
                    {
                        EquipamentoModel obj = new EquipamentoModel();
                        obj.Cliente = new ClienteModel();
                        obj.Sistema = new SistemaOperacionalModel();
                        obj.Id = Convert.ToInt32(leitor["Id"]);
                        obj.Equipamento = leitor["Descricao"].ToString();
                        obj.Modelo = leitor["Modelo"].ToString();
                        obj.Fabricante = leitor["Fabricante"].ToString();
                        obj.Tipo = leitor["Tipo"].ToString();
                        obj.Codigo = leitor["Codigo"].ToString();
                        obj.NumSerie = leitor["NumSerie"].ToString();
                        obj.Cliente.Nome = leitor["Nome"].ToString();
                        obj.Cliente.Cpf = leitor["Cpf"].ToString();
                        obj.Cliente.Telefone = leitor["Telefone"].ToString();
                        obj.PlacaMae = leitor["PlacaMae"].ToString();
                        obj.PlacaSom = leitor["PlacaSom"].ToString();
                        obj.PlacaVideo = leitor["PlacaVideo"].ToString();
                        obj.MemoriaRam = leitor["MemoriaRam"].ToString();
                        obj.DiscoRigido = leitor["DiscoRigido"].ToString();
                        obj.Processador = leitor["Processador"].ToString();
                        obj.DataEntrada = Convert.ToDateTime(leitor["DataEntrada"]);
                        obj.DataSaida = Convert.ToDateTime(leitor["DataSaida"]);
                        obj.Sistema.SistemaOperacional = leitor["NomeSistema"].ToString();
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
