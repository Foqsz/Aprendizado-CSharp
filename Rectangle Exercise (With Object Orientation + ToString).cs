using System;
using System.Globalization;

namespace Course
{
    internal class Valores
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
        public override string ToString()
        {
            double perimetro = Perimetro();
            double diagonal = Diagonal();
            return "Area: " + Largura * Altura + ", Perimetro: " + perimetro.ToString("F2", CultureInfo.InvariantCulture) + " Diagonal: " + diagonal.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}



using System;
using System.Globalization;

namespace Course  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Valores v = new Valores(); 

            Console.WriteLine("Entre a largura e a altura do retangulo: ");
            v.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA: " + v.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO: " + v.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + v.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
