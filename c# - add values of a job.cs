using System;
using System.Globalization;

namespace Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, nh, sl;
            double t, vh;

            n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            nh = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  


            t = vh * nh;

            Console.WriteLine("Number: " + n);
            Console.WriteLine("Salary: " + t.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
