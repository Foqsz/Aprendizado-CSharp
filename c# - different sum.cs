using System;
using System.Globalization;

namespace Calculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, di;

            A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            D = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            di = A * B - C * D;

            Console.WriteLine("DIFERENCA=" + di.ToString(CultureInfo.InvariantCulture)); 
               
        }
    }
}
