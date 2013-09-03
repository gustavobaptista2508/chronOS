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
    public class AtendimentoService
    {
        public static bool Inserir(AtendimentoModel Obj)
        {
            SqlConnection conn = Conexao.ObterConexao();
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO Atendimento (UsuarioId, DataAtendimento, HoraAtendimento, Reclamacao, Codigo, IdCliente, Status ");
            sql.Append("VALUES (@UsuarioId, @DataAtendimento, @HoraAtendimento, @Reclamacao, @Codigo, @IdCliente, @Status");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.AddWithValue("@UsuarioId", Obj.UsuarioId.Id);
            cmd.Parameters.AddWithValue("@DataAtendimento", Obj.DataAtendimento);
            cmd.Parameters.AddWithValue("@HoraAtendimento", Obj.HoraAtendimento);
            cmd.Parameters.AddWithValue("@Reclamacao", Obj.Reclamacao);
            cmd.Parameters.AddWithValue("@Codigo", Obj.Codigo);
            cmd.Parameters.AddWithValue("@IdCliente", Obj.Cliente.Id);
            cmd.Parameters.AddWithValue("@Status", Obj.Status);
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
    }
}
