using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Chronos.Service.Local
{
    public class Funcionarios
    {
        public int Id { get; set; }

        [StringLength(160)]
        public string Nome { get; set; }

        [StringLength(70)]
        public string Endereco { get; set; }

        [StringLength(40)]
        public string Bairro { get; set; }

        [StringLength(60)]
        public string Cidade { get; set; }

        [StringLength(40)]
        public string Estado { get; set; }

        [StringLength(8)]
        public string Cep { get; set; }

        [StringLength(24)]
        public string Telefone { get; set; }
    }
}
