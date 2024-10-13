using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        // Verifica se é uma matriz (array)
        bool isArray = array.GetType().IsArray;
        Console.WriteLine($"É uma matriz? {isArray}");

        // Exibe o número de dimensões (rank)
        int rank = array.Rank;
        Console.WriteLine($"Número de dimensões: {rank}");
    }
}
