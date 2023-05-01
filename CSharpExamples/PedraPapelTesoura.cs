using System;

namespace CSharpExamples
{
    class PedraPapelTesoura
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos jogar pedra-papel-tesoura!");

            while (true)
            {
                string jogadaUsuario = ObterJogadaUsuario();
                string jogadaComputador = ObterJogadaComputador();
                ImprimirJogadas(jogadaUsuario, jogadaComputador);

                string resultado = ObterResultado(jogadaUsuario, jogadaComputador);
                Console.WriteLine(resultado);

                if (!JogarNovamente())
                {
                    break;
                }
            }

            Console.WriteLine("Obrigada por jogar!");
        }

        static string ObterJogadaUsuario()
        {
            Console.Write("Insira seu movimento (pedra, papel, ou tesoura): ");
            return Console.ReadLine().ToLower();
        }

        static string ObterJogadaComputador()
        {
            string[] jogadaComputador = { "pedra", "papel", "tesoura" };
            return jogadaComputador[new Random().Next(0, 3)];
        }

        static void ImprimirJogadas(string jogadaUsuario, string jogadaComputador)
        {
            Console.WriteLine("Você escolheu " + jogadaUsuario + ". O computador escolheu " + jogadaComputador + ".");
        }

        static string ObterResultado(string jogadaUsuario, string jogadaComputador)
        {
            if (jogadaUsuario == jogadaComputador)
            {
                return "É um empate!";
            }
            else if (jogadaUsuario == "pedra" && jogadaComputador == "tesoura"
                    || jogadaUsuario == "papel" && jogadaComputador == "pedra"
                    || jogadaUsuario == "tesoura" && jogadaComputador == "papel")
            {
                return "Você venceu!";
            }
            else
            {
                return "O computador venceu!";
            }
        }

        static bool JogarNovamente()
        {
            Console.Write("Você quer jogar novamente? (s/n): ");
            return Console.ReadLine().ToLower() == "s";
        }
    }
}

