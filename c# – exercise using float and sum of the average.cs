using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            float n1, n2, n3, n4, media, NotaExame;

            string[] notas = Console.ReadLine().Split(' ');

            n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            media = ((n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / (2 + 3 + 4 + 1));


            if (media >= 7.0)
            {

                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");

            }
            else
            {

                if (media < 5.0)
                {

                    Console.WriteLine("Media: {0:f1}", (media - 0.01).ToString("F1", CultureInfo.InvariantCulture));

                    Console.WriteLine("Aluno reprovado.");

                }
                else
                {

                    Console.WriteLine("Media: {0:f1}", (media - 0.01).ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno em exame.");
                    NotaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Nota do exame: " + NotaExame.ToString("F1", CultureInfo.InvariantCulture));
                    media = (media + NotaExame) / 2;

                    if (media >= 5.0)
                    {

                        Console.WriteLine("Aluno aprovado.");

                    }
                    else
                    {

                        Console.WriteLine("Aluno reprovado.");

                    }

                    Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));

                }
            }
        }
    }
}
