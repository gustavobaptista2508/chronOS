using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Chronos.Service.Configurar
{
    public class Configuracoes
    {
        public static bool ConexaoSucesso()
        {
            var conn = new SqlConnection(
                ObterConnectionString().ConnectionString);
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static SqlConnectionStringBuilder ObterConnectionString()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory + "chronConfig.dat";
            var StringBuilder = new SqlConnectionStringBuilder();
            try
            {
                if (File.Exists(dir))
                {
                    var leitor = new StreamReader(dir);
                    var linha = leitor.ReadLine();
                    StringBuilder.DataSource = linha.Substring(4);
                    linha = leitor.ReadLine();
                    StringBuilder.InitialCatalog = linha.Substring(4);
                    if (!leitor.EndOfStream)
                    {
                        linha = leitor.ReadLine();
                        StringBuilder.UserID = linha.Substring(4);
                        linha = leitor.ReadLine();
                        StringBuilder.Password = linha.Substring(4);
                    }
                    else
                    {
                        StringBuilder.IntegratedSecurity = true;
                    }
                    leitor.Close();
                }
                else
                {
                    StringBuilder.DataSource = @"(LocalDB)\v11.0";
                    StringBuilder.AttachDBFilename = "|DataDirectory|\\chroDatabase.mdf";
                    StringBuilder.IntegratedSecurity = true;
                    StringBuilder.PersistSecurityInfo = true;
                }
                StringBuilder.ConnectTimeout = 30;
                return StringBuilder;
            }
            catch
            {
                return null;
            }
        }

        public static bool GravarConfig(string servidor, string nomeBD, string usuario, string senha)
        {
            try
            {
                var dir = AppDomain.CurrentDomain.BaseDirectory + "chronConfig.dat";
                if (File.Exists(dir))
                {
                    File.Delete(dir);
                }
                var gravar = new StreamWriter(dir);
                gravar.WriteLine("SRV={0}", servidor+"\\SQLEXPRESS");
                gravar.WriteLine("NBD={0}", nomeBD);
                if (!string.IsNullOrEmpty(usuario))
                {
                    gravar.WriteLine("USR={0}", usuario);
                    gravar.WriteLine("PWD={0}", senha);
                }
                gravar.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
