using Course.Models;
using System;
using System.Collections.Immutable;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("PB", "Paraíba");
            estados.Add("BA", "Bahia");
            estados.Add("DF", "Brasilía");

            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
            }
            Console.WriteLine("--------------------------------------");

            estados.Remove("BA");
            estados["DF"] = "Destrito Federal";

            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
            }

            string chave = "PB";
            Console.WriteLine($"Verificando o elemento: {chave}");

            if (estados.ContainsKey(chave))
            {
                Console.WriteLine($"Valor existente: {chave}");
            }
            else
            {
                Console.WriteLine($"Valor não existe. É seguro adicionar a chave {chave}");
            }
        }
    }
}
