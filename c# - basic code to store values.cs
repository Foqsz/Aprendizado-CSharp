using System;
using System.Globalization;

namespace value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
                
            Console.WriteLine("Ola. O que deseja consumir? ");
            Console.WriteLine(" 1.Álcool - 2.Gasolina - 3.Diesel - 4.Fim");
            int pedido = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            while (pedido != 4)
            {
                if (pedido == 1)
                {
                    alcool = alcool + 1;
                }

                else if (pedido == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (pedido == 3)
                {
                    diesel = diesel + 1;
                }

                pedido = int.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }                        
}
