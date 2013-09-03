using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Service.Models
{
    public class SistemaOperacionalModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _sistemaOperacional;

        public string SistemaOperacional
        {
            get { return _sistemaOperacional; }
            set { _sistemaOperacional = value; }
        }
        private string _desenvolvedora;

        public string Desenvolvedora
        {
            get { return _desenvolvedora; }
            set { _desenvolvedora = value; }
        }
        private string _versao;

        public string Versao
        {
            get { return _versao; }
            set { _versao = value; }
        }
    }
}
