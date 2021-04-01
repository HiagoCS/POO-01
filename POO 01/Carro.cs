using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_01
{
    class Carro : Veiculo
    {
        //Objetos
        private int capacidadePortaMala;
        private bool carroceria;
        private int cadeirinha;

        //Construtor sem parâmetros
        public Carro()
            : base()
        {
            this.capacidadePortaMala = 0;
            this.carroceria = false;
            this.cadeirinha = 0;
        }

        //Construtor com parâmetros
        public Carro(string modelo, string fabricante, string placa, int ano, string cor, int num_portas, int capacidadePortaMala, int cadeirinha, bool carroceria)
            : base(modelo, fabricante, placa, ano, cor, num_portas)
        {
            this.capacidadePortaMala = capacidadePortaMala;
            this.cadeirinha = cadeirinha;
            this.carroceria = carroceria;
        }

        //Métodos especiais get e set
        public int CapacidadePortaMala
        {
            get { return capacidadePortaMala; }
            set { capacidadePortaMala = value; }
        }
        public bool Carroceria
        {
            get { return carroceria; }
            set { carroceria = value; }
        }
        public int Cadeirinha
        {
            get { return cadeirinha; }
            set { cadeirinha = value; }
        }

        public override string ToString()
        {
            return (String.Format("\n {0}\n Capacidade Máxima do Porta Malas: {1}\n Numero de Cadeirinha(s): {2}\n Tem carroceria: {3}\n ", base.ToString(), capacidadePortaMala, cadeirinha, (carroceria == true ? "Tem sim" : "Não tem")));
            
        }
    }
}
