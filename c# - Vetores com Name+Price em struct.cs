 
namespace Course
{
    internal class Comercio
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}

using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Comercio[] vect = new Comercio[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Comercio { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0;i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
