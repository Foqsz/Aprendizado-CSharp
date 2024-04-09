using System;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista para armazenar os itens
            List<Lista> itens = new List<Lista>();

            // TODO: Solicite os itens ao usuário
            for (int i = 1; i <= 1; i++)
            {
                string item1 = Console.ReadLine();
                string item2 = Console.ReadLine();
                string item3 = Console.ReadLine();

                itens.Add(new Lista(item1, item2, item3));
            }

            // Exibe a lista de itens
            Console.WriteLine("Lista de itens:");
            foreach (Lista item in itens)
            {
                Console.WriteLine($"- {item.Item1}");
                Console.WriteLine($"- {item.Item2}");
                Console.WriteLine($"- {item.Item3}");
            }

        }
    }
    internal class Lista
    {
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }

        public Lista(string item1, string item2, string item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }
    }
}
