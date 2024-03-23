using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            double horasTrabalhadas, valorRecebido, salarioTotal;

            number = int.Parse(Console.ReadLine());
            horasTrabalhadas = double.Parse(Console.ReadLine());
            valorRecebido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioTotal = horasTrabalhadas * valorRecebido;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
