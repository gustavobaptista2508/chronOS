//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chronos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdFuncao { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> Ativo { get; set; }
        public string Telefone { get; set; }
    }
}