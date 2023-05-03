using System;

namespace CSharpExamples 
{
    class DiaDaSemana {
        static void Main() {
            int diaDaSemana = 1;

            switch (diaDaSemana) {
                case 1:
                    Console.WriteLine("Hoje é segunda-feira");
                    break;
                case 2:
                    Console.WriteLine("Hoje é terça-feira");
                    break;
                case 3:
                    Console.WriteLine("Hoje é quarta-feira");
                    break;
                case 4:
                    Console.WriteLine("Hoje é quinta-feira");
                    break;
                case 5:
                    Console.WriteLine("Hoje é sexta-feira");
                    break;
                case 6:
                    Console.WriteLine("Hoje é sábado");
                    break;
                case 7:
                    Console.WriteLine("Hoje é domingo");
                    break;
                default:
                    Console.WriteLine("Dia da semana inválido");
                    break;
            }
        }
    }
}

// é necessário colocar o código dentro de um método ou função (class)
// sendo necessáro também incluir essa classe no namespace que se encontra o main
