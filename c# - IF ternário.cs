using Course.Models;
using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            bool ehPar = false;

            //IF Ternario (Apenas para casos de IF e ELSE)
            ehPar = numero % 2 == 0; 
            Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));
            
            /*
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O Número {numero} é par");
            }
            else
            {
                Console.WriteLine($"O Número {numero} é ímpar");
            }*/


        }
    }
}
