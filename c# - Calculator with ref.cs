using System;
using System.Security.Cryptography.X509Certificates;

namespace Course
{
    internal class Calculator
    {
        public static void Triple(ref int x) //ref = modificador de parametro; 
        {
            x = x * 3;
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
            int a = int.Parse(Console.ReadLine());
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
