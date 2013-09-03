using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Service.Models
{
    public class ProdutoModel
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _Descricao;

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }
        private string _Fabricante;

        public string Fabricante
        {
            get { return _Fabricante; }
            set { _Fabricante = value; }
        }

        private string _Preco;

        public string Preco
        {
            get { return _Preco; }
            set { _Preco = value; }
        }

        private int _NumEstoque;

        public int NumEstoque
        {
            get { return _NumEstoque; }
            set { _NumEstoque = value; }
        }
        private string _Codigo;

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }
        private string _CodigoBarras;

        public string CodigoBarras
        {
            get { return _CodigoBarras; }
            set { _CodigoBarras = value; }
        }

        private string _Grupo;

        public string Grupo
        {
            get { return _Grupo; }
            set { _Grupo = value; }
        }

        private string _Fornecedor;

        public string Fornecedor
        {
            get { return _Fornecedor; }
            set { _Fornecedor = value; }
        }
        private string _PrecoVenda;

        public string PrecoVenda
        {
            get { return _PrecoVenda; }
            set { _PrecoVenda = value; }
        }
        private string _Unidade;

        public string Unidade
        {
            get { return _Unidade; }
            set { _Unidade = value; }
        }
        private DateTime _DataEntrada;

        public DateTime DataEntrada
        {
            get { return _DataEntrada; }
            set { _DataEntrada = value; }
        }
    }
}
