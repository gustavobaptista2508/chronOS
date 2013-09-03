using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Service
{
    public class SessaoSistema
    {
        private static string _nome;

        public static string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private static string _senha;

        public static string Senha
        {
            get { return SessaoSistema._senha; }
            set { SessaoSistema._senha = value; }
        }

        private static string _login;

        public static string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        private static string _perfil;

        public static string Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }
    }
}
