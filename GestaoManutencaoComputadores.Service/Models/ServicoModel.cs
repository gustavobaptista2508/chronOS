using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoManutencaoComputadores.Service;

namespace GestaoManutencaoComputadores.Service.Models
{
    public class ServicoModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _serviço;

        public string Serviço
        {
            get { return _serviço; }
            set { _serviço = value; }
        }
        private decimal _valor;

        public decimal Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
    }
}
