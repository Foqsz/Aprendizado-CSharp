using System;
using System.Globalization;

namespace Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite tres numeros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double resultado = Maior(a, b, c);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int a1, int b2, int c3)    
        {
            int m;
            if (a1 > b2 && a1 > c3)
            {
                m = a1;
            }
            else if (b2 > c3)
            {
                m = b2;
            }
            else
            {
                m = c3;
            }
            return m;
        }
    }                    
}
