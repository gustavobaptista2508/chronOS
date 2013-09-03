using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoManutencaoComputadores.Service.Models
{
    public class PerfilModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _perfil;

        public string Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }
    }
}
