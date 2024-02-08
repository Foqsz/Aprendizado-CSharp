using System;
using System.Globalization;

namespace Pass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha de acesso: ");
            double senha = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (senha != 2002)
            {
                Console.WriteLine("Senha valida!");
                Console.WriteLine("Digite Novamente.");
                senha = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }

            Console.WriteLine("Senha Valida, acesso permitido!");
        }
    }
                           
}
