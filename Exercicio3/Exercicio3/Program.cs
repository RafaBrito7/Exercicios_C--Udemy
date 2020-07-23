using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;

            Console.WriteLine("DIFERENÇA = " + diferenca);
        }
    }
}
