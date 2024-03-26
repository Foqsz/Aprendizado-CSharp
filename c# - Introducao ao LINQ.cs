using System;
using System.Linq;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // specify the data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            // Define the query expression 
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //execute the query

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
