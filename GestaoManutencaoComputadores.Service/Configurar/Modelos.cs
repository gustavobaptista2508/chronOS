using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Service.Configurar
{
    public class Modelos
    {
        private static string _enderecoServer;

        public static string EnderecoServer
        {
            get { return Modelos._enderecoServer; }
            set { Modelos._enderecoServer = value; }
        }
        private static string _usuarioServer;

        public static string UsuarioServer
        {
            get { return Modelos._usuarioServer; }
            set { Modelos._usuarioServer = value; }
        }
        private static string _senhaServer;

        public static string SenhaServer
        {
            get { return Modelos._senhaServer; }
            set { Modelos._senhaServer = value; }
        }
        private static string _nomeBanco;

        public static string NomeBanco
        {
            get { return Modelos._nomeBanco; }
            set { Modelos._nomeBanco = value; }
        }

        private static string _tipoConexao;

        public static string TipoConexao
        {
            get { return Modelos._tipoConexao; }
            set { Modelos._tipoConexao = value; }
        }

        private static string _nomeServidor;

        public static string NomeServidor
        {
            get { return Modelos._nomeServidor; }
            set { Modelos._nomeServidor = value; }
        }
    }
}
