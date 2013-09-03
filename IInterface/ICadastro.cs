using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IInterface
{
    public interface ICadastro
    {
        bool Mostrar(Form form);
        bool Inserir(Form form);
        bool Alterar(Form form);
        bool Excluir();
        int Codigo { get; set; }
    }
}
