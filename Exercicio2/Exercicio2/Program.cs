using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do Raio: ");
            float raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            const float pi = 3.14159F;

            Console.WriteLine("A = " + ((pi * (raio * raio))).ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
