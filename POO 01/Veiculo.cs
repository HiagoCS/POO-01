using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_01
{
    class Veiculo
    {
        //Objetos
        private string modelo;
        private string fabricante;
        private string placa;
        private int ano;
        private string cor;
        private int num_portas;

        //Construtor sem parâmetros
        public Veiculo()
        {
            this.modelo = null;
            this.fabricante = null;
            this.placa = null;
            this.ano = 0;
            this.cor = null;
            this.num_portas = 0;
        }

        //Construtor com parâmetros
        public Veiculo(string modelo, string fabricante, string placa, int ano, string cor, int num_portas)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.placa = placa;
            this.ano = ano;
            this.cor = cor;
            this.num_portas = num_portas;
        }

        //Métodos especiais get e set
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public int Num_Portas
        {
            get { return num_portas; }
            set { num_portas = value; }
        }

        public override string ToString()
        {
            return (String.Format("\n Modelo: {0} \n Fabricante: {1} \n Placa: {2} \n Ano: {3} \n Cor: {4} \n Numero de Portas: {5}", modelo.Substring(0,1).ToUpper()+modelo.Substring(1).ToLower(), fabricante.Substring(0,1).ToUpper()+fabricante.Substring(1).ToLower(), placa, ano, cor.Substring(0, 1).ToUpper()+cor.Substring(1).ToLower(), num_portas));
        }
    }
}
