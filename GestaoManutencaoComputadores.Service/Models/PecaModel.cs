using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoManutencaoComputadores.Service.Models
{
    public class PecaModel
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
        private string _peca;

        public string Peca
        {
            get { return _peca; }
            set { _peca = value; }
        }
        private string _fabricante;

        public string Fabricante
        {
            get { return _fabricante; }
            set { _fabricante = value; }
        }
        private string _drive;

        public string Drive
        {
            get { return _drive; }
            set { _drive = value; }
        }
    }
}
