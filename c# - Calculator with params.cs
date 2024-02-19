using System; 

namespace Course
{
    internal class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}

 
using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
