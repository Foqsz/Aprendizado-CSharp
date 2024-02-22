using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[6];

            for (int i = 0; i < 6; i++)
            {
                numeros[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            int positivos = 0;

            foreach (double numero in numeros)
            {
                if (numero > 0)
                {
                positivos++;
                }
                
            }

            Console.WriteLine("{0} valores positivos", positivos);
        }
    }
}
