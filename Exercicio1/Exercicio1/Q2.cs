using System;


namespace Exercicio1
{
    class Q2
    {
        static void main(String[] args)
        {
            Console.WriteLine("Informe o valor do Raio: ");
            float raio = float.Parse(Console.ReadLine());

            const float pi = 3.14159F;

            Console.WriteLine("A = " + (pi * (raio * raio)));

        }
    }
}
