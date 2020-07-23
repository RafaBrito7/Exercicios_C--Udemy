using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("SOMA = " + (num1 + num2));

        }
    }
}
