using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int consumo;
            double distancia, soma;

            consumo = int.Parse(Console.ReadLine());
            distancia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = consumo / distancia;

            Console.WriteLine("{0} km/l", soma.ToString("F3", CultureInfo.InvariantCulture));




        }
    }
}
