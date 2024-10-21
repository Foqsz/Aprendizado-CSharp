using System;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int mmc = CalcularMMC(num1, num2);
        Console.WriteLine($"O MMC de {num1} e {num2} é: {mmc}");
    }

    static int CalcularMMC(int a, int b)
    {
        return (a * b) / CalcularMDC(a, b);
    }

    static int CalcularMDC(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
