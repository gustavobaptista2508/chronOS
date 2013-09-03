using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoManutencaoComputadores.Service;
using Chronos.Service.Models;

namespace GestaoManutencaoComputadores.Service.Models
{
    public class UsuarioModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _login;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        private string _senha;

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        private FuncionarioModel _funcionario;

        public FuncionarioModel Funcionario
        {
            get { return _funcionario; }
            set { _funcionario = value; }
        }

        private PerfilModel _perfil;

        public PerfilModel Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _ativo;

        public string Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }
    }
}
