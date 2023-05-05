using System;

namespace CSharpExemplos
{
    class CalculaTempo
    {
        static void Main(string[] args)
        {
            // lê o tempo em segundos a partir do usuário
            Console.Write("Informe o tempo em segundos: ");
            int tempoSegundos = int.Parse(Console.ReadLine());

            // calcula o tempo em horas, minutos e segundos
            int horas = tempoSegundos / 3600;
            int minutos = (tempoSegundos % 3600) / 60;
            int segundos = tempoSegundos % 60;

            // imprime o tempo em horas, minutos e segundos
            Console.WriteLine("O tempo é o equivalente a {0} horas, {1} minutos e {2} segundos.", horas, minutos, segundos);
        }
    }
}