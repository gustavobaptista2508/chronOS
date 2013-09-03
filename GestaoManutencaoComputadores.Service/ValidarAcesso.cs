using Chronos.Service.Models;
using GestaoManutencaoComputadores.Service;
using GestaoManutencaoComputadores.Service.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Service
{
    public class ValidarAcesso
    {
        public static string Nome { get; set; }
        public static string Perfil { get; set; }
        public static string Usuario { get; set; }
        public static string Senha { get; set; }


        public static List<UsuarioModel> Acesso(string usuario, string senha)
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();
            using (SqlConnection conn = Conexao.ObterConexao())
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT Usuario.Id, Usuario.Usuario, Usuario.Email, Perfil.Perfil, Funcionario.Nome, Usuario.Ativo ");
                sql.Append("FROM Usuario INNER JOIN Perfil ON Perfil.Id=Usuario.IdPerfil INNER JOIN Funcionario ON Funcionario.Id=Usuario.IdFuncionario WHERE Usuario.Usuario = @Usuario OR Usuario.Email = @Email AND Usuario.Senha = @Senha");
                using (SqlCommand cmd = new SqlCommand(sql.ToString(), conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);
                    cmd.Parameters.AddWithValue("@Email", usuario);
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
                        leitor.Close();
                        leitor.Dispose();
                        cmd.Clone();
                        cmd.Dispose();
                        Nome = lista[0].Funcionario.Nome;
                        Perfil = lista[0].Perfil.Perfil;
                        Usuario = lista[0].Login;
                        
                    }
                    catch
                    { }
                    finally
                    {
                        
                        conn.Close();
                    }
                }
            }          
            return lista;
        }
        
    }
}
