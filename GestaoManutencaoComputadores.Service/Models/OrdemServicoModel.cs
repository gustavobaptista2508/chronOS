using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoManutencaoComputadores.Service.Models
{
    public class OrdemServicoModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private ServicoModel _servico;

        public ServicoModel Servico
        {
            get { return _servico; }
            set { _servico = value; }
        }
        private ClienteModel _cliete;

        public ClienteModel Cliete
        {
            get { return _cliete; }
            set { _cliete = value; }
        }
        private string _diagnostico;

        public string Diagnostico
        {
            get { return _diagnostico; }
            set { _diagnostico = value; }
        }
        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        private string _realizado;

        public string Realizado
        {
            get { return _realizado; }
            set { _realizado = value; }
        }
        private GarantiaModel _garantia;

        internal GarantiaModel Garantia
        {
            get { return _garantia; }
            set { _garantia = value; }
        }
        private DateTime _entrada;

        public DateTime Entrada
        {
            get { return _entrada; }
            set { _entrada = value; }
        }
        private DateTime _saida;

        public DateTime Saida
        {
            get { return _saida; }
            set { _saida = value; }
        }
        private decimal _total;

        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }
        private string _defeito;

        public string Defeito
        {
            get { return _defeito; }
            set { _defeito = value; }
        }
        private EquipamentoModel _equipamento;

        internal EquipamentoModel Equipamento
        {
            get { return _equipamento; }
            set { _equipamento = value; }
        }
        private PecaModel _peca;

        public PecaModel Peca
        {
            get { return _peca; }
            set { _peca = value; }
        }
    }
}
