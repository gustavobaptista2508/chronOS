using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoManutencaoComputadores.Service;
using Chronos.Service.Models;

namespace GestaoManutencaoComputadores.Service.Models
{
    public class ClienteModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _dataCadastro;

        public DateTime DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _endereco;

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
        private string _bairro;

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        private string _cidade;

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        private string _cep;

        public string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }
        private string _estado;

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private string _telefone;

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
        private string _celular;

        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }
        private string _cpf;

        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        private string _rg;

        public string Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }

        private FuncaoModel _funcao;

        public FuncaoModel Funcao
        {
            get { return _funcao; }
            set { _funcao = value; }
        }
    }
}
