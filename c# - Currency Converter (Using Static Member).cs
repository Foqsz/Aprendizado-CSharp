using System;
using System.Globalization;

namespace Course
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;

        }
    }
}

using System;
using System.Globalization;

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.Write("Qual é a cotação do Dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar?: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
