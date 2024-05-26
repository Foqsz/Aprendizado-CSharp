using System;

class Program
{
    static void Main()
    {
        // Usando Math.Sqrt para calcular a raiz quadrada
        double number = 25.0;
        double sqrtResult = Math.Sqrt(number);
        Console.WriteLine($"A raiz quadrada de {number} é {sqrtResult}");

        // Usando Math.Pow para calcular a potência
        double baseNumber = 2.0;
        double exponent = 3.0;
        double powResult = Math.Pow(baseNumber, exponent);
        Console.WriteLine($"{baseNumber} elevado a {exponent} é {powResult}");

        // Usando Math.Abs para obter o valor absoluto
        double negativeNumber = -15.5;
        double absResult = Math.Abs(negativeNumber);
        Console.WriteLine($"O valor absoluto de {negativeNumber} é {absResult}");
    }
}
