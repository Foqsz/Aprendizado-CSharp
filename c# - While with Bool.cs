using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float notaUm = 0, notaDois = 0; // Aqui colocando valor padrao nas notas, no caso botei 0.
            bool notaUmValida = false, notaDoisValida = false;

            // Aqui eu fiz um loop para validar a primeira nota
            while (!notaUmValida)
            {
                notaUm = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (notaUm < 0 || notaUm > 10)
                { 
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    // Se a nota estiver dentro do intervalo [0, 10] (falado no exercicio), marca como válida e sai do loop. O msm pra os abaixos.
                    notaUmValida = true;
                }
            }

            // Loop para validar a segunda nota
            while (!notaDoisValida)
            {
                notaDois = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (notaDois < 0 || notaDois > 10)
                { 
                    Console.WriteLine("nota invalida");
                }
                else
                { 
                    notaDoisValida = true;
                }
            }
             
            float media = (notaUm + notaDois) / 2.0f;
            Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
