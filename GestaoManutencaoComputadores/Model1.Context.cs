﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Equipamento> Equipamentoes { get; set; }
        public DbSet<EquipamentoHardware> EquipamentoHardwares { get; set; }
        public DbSet<Funcao> Funcaos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Garantia> Garantias { get; set; }
        public DbSet<LoginCliente> LoginClientes { get; set; }
        public DbSet<OrdemServico> OrdemServicoes { get; set; }
        public DbSet<Peca> Pecas { get; set; }
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<Servico> Servicoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}