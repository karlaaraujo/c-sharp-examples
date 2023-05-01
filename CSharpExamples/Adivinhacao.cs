using System;

namespace CSharpExamples 
{
    class Adivinhacao
    {
        static void Main(string[] args)
        {
            int numeroSecreto = GerarNumeroSecreto();
            int tentativas = 10;

            Console.WriteLine("Acerte o número secreto entre 1 e 100!");
            Console.WriteLine("Você possui " + tentativas + " tentativas restantes.");

            while (tentativas > 0)
            {
                int palpite = ObterPalpite();

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você acertou o número secreto.");
                    return;
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Seu palpite é muito baixo.");
                }
                else
                {
                    Console.WriteLine("Seu palpite é muito alto.");
                }

                tentativas--;
                Console.WriteLine("Você possui " + tentativas + " tentativas restantes.");
            }

            Console.WriteLine("Game over. As tentativas esgotaram.");
            Console.WriteLine("O número secreto era " + numeroSecreto + ".");
        }

        static int GerarNumeroSecreto()
        {
            return new Random().Next(1, 101);
        }

        static int ObterPalpite()
        {
            Console.Write("Insira seu palpite: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
