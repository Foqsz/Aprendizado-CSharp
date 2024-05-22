using System;

class Program
{
    static void Main()
    {
        int totalDias = int.Parse(Console.ReadLine());

        int anos = totalDias / 365;
        int diasRestantes = totalDias % 365;
        int meses = diasRestantes / 30;
        int diasFinais = diasRestantes % 30;

        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{diasFinais} dia(s)");
    }
}
