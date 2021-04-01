using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro[] car = new Carro[300];
            Caminhao[] truck = new Caminhao[200];
            int cc = 0; int ct = 0; int op = 0;
            Console.Clear();
            do
            {
                op = Menu();
                switch(op)
                {
                    case 1: car[cc++] = cadastrarCarro(); break;

                    case 2: truck[ct++] = cadastrarCaminhao(); break;

                    case 3: consultarPlaca(truck, ct, car, cc); break;

                    case 4: consultarModelo(truck, ct); break;

                    case 5: consultarCor(car, cc); break;

                    case 6: exibirCarros(car, cc); break;

                    case 7: exibirCaminhao(truck, ct); break;

                    case 0: break;

                    default:Console.WriteLine("Resposta Invalida"); break;
                }
            }
            while (op != 0);
        }
        public static int Menu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 1 – Cadastrar carro\r\n 2 – Cadastrar caminhão\r\n 3 – Consultar por placa\r\n 4 – Consultar caminhão por modelo/marca\r\n 5 – Consultar carro por cor\r\n 6 – Exibir todos os carros cadastrados\r\n 7 – Exibir todos os caminhões cadastrados\r\n 0 - Sair");
            return int.Parse(Console.ReadLine());
        }
        public static Carro cadastrarCarro()
        {
            Console.Clear();
            Console.Write("Modelo: ");
            string m = Console.ReadLine();
            Console.Write("Fabricante: ");
            string f = Console.ReadLine();
            Console.Write("Placa: ");
            string p = Console.ReadLine();
            Console.Write("Ano: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Cor: ");
            string c = Console.ReadLine();
            Console.Write("Número de Portas: ");
            int np = int.Parse(Console.ReadLine());
            Console.Write("Capacidade Max. Porta-Malas (KG): ");
            int cpm = int.Parse(Console.ReadLine());
            Console.Write("Numero de Cadeirinhas infantis: ");
            int cad = int.Parse(Console.ReadLine());
            Console.Write("Tem Carroceria? S/N: ");
            string op = Console.ReadLine();
            bool bag;
            if (op.ToUpper() == "S")
            {
                bag = true;
            }
            else
            {
                bag = false;
            }
            Console.Clear();
            return new Carro(m, f, p, a, c, np, cpm, cad, bag);
        }
        
        public static Caminhao cadastrarCaminhao()
        {
            Console.Clear();
            Console.Write("Modelo: ");
            string m = Console.ReadLine();
            Console.Write("Fabricante: ");
            string f = Console.ReadLine();
            Console.Write("Placa: ");
            string p = Console.ReadLine();
            Console.Write("Ano: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Cor: ");
            string c = Console.ReadLine();
            Console.Write("Número de Portas: ");
            int np = int.Parse(Console.ReadLine());
            Console.Write("Numero de Eixos: ");
            int ne = int.Parse(Console.ReadLine());
            Console.Write("Peso de carga máximo (KG): ");
            double pg = double.Parse(Console.ReadLine());
            Console.Write("Numero de Acentos: ");
            int ac = int.Parse(Console.ReadLine());
            Console.Clear();
            return new Caminhao(m, f, p, a, c, np, ne, pg, ac);
        }
        public static void exibirCarros(Carro[] car, int c)
        {
            Console.Clear();
            Console.WriteLine("###_Carros registrados_###");
            
            if (c > 0)
            {
                
                for (int i = 0; i < c; i++)
                {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("##################");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(car[i].ToString());
                }
            }
            Console.WriteLine("Aperte qualquer botão para voltar para o menu");
            Console.ReadKey();
            Console.Clear();
        }
        public static void exibirCaminhao(Caminhao[] truck, int ct)
        {
            Console.Clear();
            Console.WriteLine("###_Caminhões registrados_###");
            if (ct > 0)
            {
                
                for (int i = 0; i < ct; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("##################");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(truck[i].ToString());
                }
            }
            Console.WriteLine("Aperte qualquer botão para voltar para o menu");
            Console.ReadKey();
            Console.Clear();
        }
        public static void consultarPlaca(Caminhao[] truck, int ct, Carro[] car, int c)
        {
            Console.Clear();
            Console.Write("Digite a placa: ");
            string placa = Console.ReadLine();
            Console.Clear();
            if(c > 0)
            {
                Console.WriteLine("###_Carros registrados_###");
                for (int i = 0; i < c; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("##################");
                    if (placa == car[i].Placa)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Carro {0}:", i + 1);
                        Console.WriteLine(car[i].ToString());

                    }
                }
            }
            else
            {

            }
            if (ct > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("###_Caminhões registrados_###");
                for (int i = 0; i < ct; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("##################");
                    Console.WriteLine("");
                    if (placa == truck[i].Placa)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Caminhão {0}:", i + 1);
                        Console.WriteLine(truck[i].ToString());

                    }
                }
            }
            else
            {

            }
            Console.WriteLine("Aperte qualquer botão para voltar para o menu");
            Console.ReadKey();
            Console.Clear();
        }
        public static void consultarModelo(Caminhao[] truck, int ct)
        {
            Console.Clear();
            Console.Write("Digite o modelo: ");
            string mod = Console.ReadLine();
            Console.Clear();
            if (ct > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("###_Caminhões registrados_###");
                for (int i = 0; i < ct; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("##################");
                    Console.WriteLine("");
                    if (mod == truck[i].Modelo)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Caminhão {0}:", i + 1);
                        Console.WriteLine(truck[i].ToString());

                    }
                }
            }
            else
            {

            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Aperte qualquer botão para voltar para o menu");
            Console.ReadKey();
            Console.Clear();
        }
        public static void consultarCor(Carro[] car, int c)
        {
            Console.Clear();
            Console.Write("Digite a cor: ");
            string cor = Console.ReadLine();
            Console.Clear();
            if (c > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("###_Carros registrados_###");
                for (int i = 0; i < c; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("##################");
                    Console.WriteLine("");
                    if (cor == car[i].Cor)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Carro {0}:", i + 1);
                        Console.WriteLine(car[i].ToString());

                    }
                }
            }
            else
            {

            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Aperte qualquer botão para voltar para o menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
