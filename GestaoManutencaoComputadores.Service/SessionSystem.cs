using GestaoManutencaoComputadores.Service;
using GestaoManutencaoComputadores.Service.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Service.System
{
    public class SessionSystem
    {
        public static string Nome { get; set; }   
        public static string Perfil { get; set; }
        public static string Usuario { get; set; }


        public static void Valores(string usuario, string senha)
        {
            SqlConnection conn = Conexao.ObterConexao();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Usuario.Usuario, Funcionario.Nome, Perfil.Perfil FROM Usuario INNER JOIN Perfil ON Perfil.Id=Usuario.IdPerfil INNER JOIN Funcionario ON Funcionario.Id=Usuario.IdFuncionario WHERE Usuario.Usuario = @Usuario OR Usuario.Email = @Email AND Usuario.Senha = @Senha");
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = usuario;
            cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senha;
            try
            {
                conn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        Usuario = leitor["Usuario"].ToString();
                        Nome = leitor["Nome"].ToString();
                        Perfil = leitor["Perfil"].ToString();
                    }
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
        }
    }
}
