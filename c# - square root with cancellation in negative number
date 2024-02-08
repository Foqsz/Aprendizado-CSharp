using System;
using System.Globalization;

namespace square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double x  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Numero negativo");
        }
    }                          
}
