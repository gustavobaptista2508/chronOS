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
    
    public partial class Garantia
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdEquipamento { get; set; }
        public System.DateTime Inicio { get; set; }
        public System.DateTime Termino { get; set; }
        public string Status { get; set; }
    }
}