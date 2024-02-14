using System;
using System.Globalization;

namespace Course
{
    internal class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
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

Calculadora calc = new Calculadora();
Console.Write("Entre o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double circ = calc.Circunferencia(raio);
double volume = calc.Volume(raio);
Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));

}   }
}    
