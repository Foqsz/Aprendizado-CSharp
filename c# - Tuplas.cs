using System;
using System.Globalization;

namespace Course
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            //Melhor método
            (int Id, string Nome, string Sobronome, decimal Altura) tupla = (1, "Victor", "Vinicius", 1.85M);
            
            ValueTuple<int, string, string, decimal> tupla2 = (2, "Pedro", "Henrique", 1.75M);
            var tupla3 = Tuple.Create(3, "Severina", "Alves", 1.60M);

            Console.WriteLine($"ID: {tupla.Id}");
            Console.WriteLine($"Nome: {tupla.Nome}");
            Console.WriteLine($"Sobrenome: {tupla.Sobronome}");
            Console.WriteLine($"Altura: {tupla.Altura.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
