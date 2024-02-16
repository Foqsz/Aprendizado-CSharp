using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; 

            for (int i = 0; i < n; i++) for (int i = 0; i < n; i++) // Aqui o i inicia como 0 em primeiro, depois ele checa se i é menor do que N(Que é definido pelo usuario), e inicia o que esta abaixo do for (caso i seja menor que N), após executar, ele soma o i++ (acrescenta um valor ao i), e volta a somar, i é menor que N? Se sim, ele refaz o comando abaixo do for novamente.
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE HIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
