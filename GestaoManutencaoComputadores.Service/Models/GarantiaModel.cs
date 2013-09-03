using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoManutencaoComputadores.Service.Models
{
    public class GarantiaModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private ClienteModel _cliente;

        public ClienteModel Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        private EquipamentoModel _equipamento;

        internal EquipamentoModel Equipamento
        {
            get { return _equipamento; }
            set { _equipamento = value; }
        }
        private DateTime _inicio;

        public DateTime Inicio
        {
            get { return _inicio; }
            set { _inicio = value; }
        }
        private DateTime _termino;

        public DateTime Termino
        {
            get { return _termino; }
            set { _termino = value; }
        }
        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
