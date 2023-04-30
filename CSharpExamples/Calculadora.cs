using System;

namespace CSharpExamples
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            bool finalizarPrograma = false;

            while(!finalizarPrograma)
            {
                imprimirMenu();

                int operacao = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Somar();
                        break;
                    case 2:
                        Subtrair();
                        break;
                    case 3:
                        Dividir();
                        break;
                    case 4:
                        Multiplicar();
                        break;
                    case 5:
                        ObterRaizQuadrada();
                        break;
                    default:
                        finalizarPrograma = true;
                        break;

                }
            }
        }

        static void imprimirMenu()
        {
            Console.WriteLine("\nEscolha uma operação: ");
            Console.WriteLine("1: Soma");
            Console.WriteLine("2: Subtração");
            Console.WriteLine("3: Divisão");
            Console.WriteLine("4: Multiplicação");
            Console.WriteLine("5: Raiz Quadrada");
            Console.WriteLine("\nInsira 0 para sair. ");
        }

        static double obterNumero()
        {
            Console.WriteLine("Digite um número: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        // Operações

        static void Somar()
        {
            double n1 = obterNumero();
            double n2 = obterNumero();

            Console.WriteLine("\nResultado: " + (n1 + n2));
        }
        
        static void Subtrair()
        {
            double n1 = obterNumero();
            double n2 = obterNumero();

            Console.WriteLine("\nResultado: " + (n1 - n2));
        }

        static void Dividir()
        {
            double n1 = obterNumero();
            double n2 = obterNumero();

            Console.WriteLine("\nResultado: " + (n1 / n2));
        }

        static void Multiplicar()
        {
            double n1 = obterNumero();
            double n2 = obterNumero();

            Console.WriteLine("\nResultado: " + (n1 * n2));
        }

        static void ObterRaizQuadrada()
        {
            double n = obterNumero();
        
            Console.WriteLine("\nResultado: " + Math.Sqrt(n));
        }


    }
}