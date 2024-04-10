using System;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("SP");
            list.Add("RJ");
            list.Add("PB");
            list.Add("DF");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Posição {i} - {list[i]}");
            }

            Console.WriteLine("");

            int contadorForeach = 0;
            foreach (string lista in list)
            {
                Console.WriteLine($"Posição {contadorForeach} - {lista}");
                contadorForeach++;
            }

        }
    }
}
