using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IInterface
{
    public interface IListagem
    {
        List<ICadastro> Lista { get; set; }
        void Inserir(ICadastro ic);
        void Mostrar();
        void Alterar(ICadastro ic);
        void Excluir(ICadastro ic);
        string ObterTituloMenu();
    }
}
