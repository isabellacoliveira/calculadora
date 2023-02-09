using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Adição ");
            Console.WriteLine("2 - Subtração ");
            Console.WriteLine("3 - Multiplicação ");
            Console.WriteLine("4 - Divisão \n");

            // armazena valor que o usuário digitou 
            // int operacao = Convert.int32(Console.ReadLine());
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(n1, n2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(n1, n2);
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(n1, n2);
                        break;
                    }
                case 4:
                    {
                        resultado = Divisao(n1, n2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Número ou caracter inválido! Digite outro número.");
                        break;
                    }
           
            }
            // conseguimos jogar um resultado dentro desse 0 
            Console.WriteLine("O resultado da operação com os números {0} e {1} é: {2}", n1, n2, resultado);
            Console.ReadLine();
        }

        public static void questions()
        {

        }
        // vamos criar um método
        // podemos mudar os nomes das variáveis 
        // isso não influi pois são métodos diferentes 
        public static int Adicao(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }

        public static int Subtracao(int n1, int n2)
        {
            int resultado = n1 - n2;
            return resultado;
        }

        public static int Multiplicacao(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }

        public static int Divisao(int n1, int n2)
        {
            int resultado = n1 / n2;
            return resultado;
        }
    }
}

