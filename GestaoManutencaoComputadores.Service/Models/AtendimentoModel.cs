using GestaoManutencaoComputadores.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Service.Models
{
    public class AtendimentoModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private ClienteModel _Cliente;

        public ClienteModel Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }

        private UsuarioModel _usuarioId;

        public UsuarioModel UsuarioId
        {
            get { return _usuarioId; }
            set { _usuarioId = value; }
        }

        private DateTime _dataAtendimento;

        public DateTime DataAtendimento
        {
            get { return _dataAtendimento; }
            set { _dataAtendimento = value; }
        }
        private DateTime _horaAtendimento;

        public DateTime HoraAtendimento
        {
            get { return _horaAtendimento; }
            set { _horaAtendimento = value; }
        }
        private string _reclamacao;

        public string Reclamacao
        {
            get { return _reclamacao; }
            set { _reclamacao = value; }
        }
        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
    }
}
