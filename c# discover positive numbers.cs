using System;  
using System.Globalization; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double sum = 0;

            for (int i = 0; i < 6; i++)
            {
                double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (n > 0)
                {
                    count++;
                    sum += n;
                }

            }

            double total = sum / count;
            Console.WriteLine($"{count} valores positivos");
            Console.WriteLine($"{total.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}

