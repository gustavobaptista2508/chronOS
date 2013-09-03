using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Service.Models
{
    public class CidadeModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private EstadoModel _estado;

        public EstadoModel Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
