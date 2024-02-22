// https://judge.beecrowd.com/pt/runs/code/37696060

using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            double A = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            double B = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            double C = double.Parse(numeros[2], CultureInfo.InvariantCulture);

            double area = 0.5 * A * C;
            double pi = 3.14159;
            double areacirculo = pi * Math.Pow(C, 2.0);
            double areatrapezio = ((A + B) * C) / 2.0;
            double areaquadrado = B * B;
            double arearetangulo = A * B;

            Console.WriteLine($"TRIANGULO: {area.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areacirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areatrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaquadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {arearetangulo.ToString("F3", CultureInfo.InvariantCulture)}");


        }
    }
}
