using Chronos.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoManutencaoComputadores.Service.Models
{
    public class EquipamentoModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _equipamento;

        public string Equipamento
        {
            get { return _equipamento; }
            set { _equipamento = value; }
        }
        private string _fabricante;

        public string Fabricante
        {
            get { return _fabricante; }
            set { _fabricante = value; }
        }
        private string _modelo;

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private ClienteModel _cliente;

        public ClienteModel Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        private string _numSerie;

        public string NumSerie
        {
            get { return _numSerie; }
            set { _numSerie = value; }
        }

        private string _sistemaOperacional;

        public string SistemaOperacional
        {
            get { return _sistemaOperacional; }
            set { _sistemaOperacional = value; }
        }

        private string _placaMae;

        public string PlacaMae
        {
            get { return _placaMae; }
            set { _placaMae = value; }
        }
        private string _placaSom;

        public string PlacaSom
        {
            get { return _placaSom; }
            set { _placaSom = value; }
        }
        private string _placaVideo;

        public string PlacaVideo
        {
            get { return _placaVideo; }
            set { _placaVideo = value; }
        }
        private string _discoRigido;

        public string DiscoRigido
        {
            get { return _discoRigido; }
            set { _discoRigido = value; }
        }
        private string _memoriaRam;

        public string MemoriaRam
        {
            get { return _memoriaRam; }
            set { _memoriaRam = value; }
        }
        private string _Processador;

        public string Processador
        {
            get { return _Processador; }
            set { _Processador = value; }
        }

        private SistemaOperacionalModel _sistema;

        public SistemaOperacionalModel Sistema
        {
            get { return _sistema; }
            set { _sistema = value; }
        }

        private DateTime _DataSaida;

        public DateTime DataSaida
        {
            get { return _DataSaida; }
            set { _DataSaida = value; }
        }

        private DateTime _DataEntrada;

        public DateTime DataEntrada
        {
            get { return _DataEntrada; }
            set { _DataEntrada = value; }
        }
    }
}
