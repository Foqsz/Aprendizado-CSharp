using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            string[] Numeros = Console.ReadLine().Split(' ');
            n1 = int.Parse(Numeros[0]);
            n2 = int.Parse(Numeros[1]);
            n3 = int.Parse(Numeros[2]);

            int[] arrCrescente = new int[] { n1, n2, n3 };
            Array.Sort(arrCrescente);

            int[] arrDecrescente = new int[] { n1, n2, n3 };
            Array.Sort(arrDecrescente);
            Array.Reverse(arrDecrescente);
             
            foreach (int num in arrCrescente)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
    }
}
