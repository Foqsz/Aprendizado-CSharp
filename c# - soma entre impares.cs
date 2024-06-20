using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
             
            for (int i = 100; i <= 200; i++)
            { 
                if (i % 2 != 0)
                {
                    soma += i;  
                }
            }

            // Exibe o resultado
            Console.WriteLine($"A soma dos números ímpares entre 100 e 200 é: {soma}");
        }
    }
    }
