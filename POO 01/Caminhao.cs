using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_01
{
    class Caminhao:Veiculo
    {
        //Objetos
        private int num_eixos;
        private double peso_max_carga;
        private int acentos;

        //Construtor sem parâmetros
        public Caminhao()
            : base()
        {
            this.num_eixos = 0;
            this.peso_max_carga = 0.0;
            this.acentos = 0;
        }

        //Construtor com parâmetros
        public Caminhao(string modelo, string fabricante, string placa, int ano, string cor, int num_portas, int num_eixos, double peso_max_carga, int acentos)
            :base(modelo, fabricante, placa, ano, cor, num_portas)
        {
            this.num_eixos = num_eixos;
            this.peso_max_carga = peso_max_carga;
            this.acentos = acentos;
        }

        //Métodos especiais get e set
        public int Num_eixos
        {
            get { return num_eixos; }
            set { num_eixos = value; }
        }
        public double Peso_max_carga
        {
            get { return peso_max_carga; }
            set { peso_max_carga = value; }
        }
        public int Acentos
        {
            get { return acentos; }
            set { acentos = value; }
        }

        public override string ToString()
        {
            return (String.Format("\n {0} \n Numeros de Eixos: {1} \n Peso máximo de carga: {2} \n Numeros de Acentos: {3}\n ", base.ToString(), num_eixos, peso_max_carga, acentos));
        }
    }
}
