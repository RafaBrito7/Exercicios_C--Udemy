using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o ID do Funcionário: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de horas trabalhadas: ");
            int workedHours = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor que recebe por hora: ");
            double paymentPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double payment = workedHours * paymentPerHour;

            Console.WriteLine("NUMBER = " + id);
            Console.WriteLine("SALARY = " + (payment).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
