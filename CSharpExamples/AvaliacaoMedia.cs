using CSharpExemplos;
using System;

namespace CSharpExemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            VouPassar vp = new VouPassar();

            Console.WriteLine("Digite a primeira nota");
            var m1 = (Parse (int.Console.ReadLine()));
            Console.WriteLine("Digite a segunda nota");
            var m2 = (Parse(int.Console.ReadLine()));
            string resultado = vp.AvaliacaoMedia(m1, m2);
            Console.WriteLine(resultado);
        }
    }

    class VouPassar
    {
        public string AvaliacaoMedia(int media1, int media2)
        {
            int mediaFinal = (media1 + media2) / 2;
            if (mediaFinal >= 7)
            {
                return "Sim, você vai passar";
            }
            else if (mediaFinal > 4 && mediaFinal < 7)
            {
                return "Quase lá, vai pra recuperação";
            }
            else
            {
                return "Só se o Ivo te der pontos";
            }
        }
    }
}
