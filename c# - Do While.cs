using System;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            // Loop do-while
            do
            {
                Console.WriteLine("O contador é: " + contador);
                contador++;
            } while (contador < 5);  // A condição para continuar o loop
        }
    }
}
