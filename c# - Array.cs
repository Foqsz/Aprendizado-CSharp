using System; 
using System.Collections.Generic;  

namespace Course  
{
    internal class Program  
    {
        static void Main(string[] args)  
        {
            // Declaração e inicialização de um array de inteiros com tamanho 4
            int[] array = new int[4];

            // Atribuição de valores aos elementos do array
            array[0] = 50;
            array[1] = 60;
            array[2] = 100;
            array[3] = 200;

            // Redimensiona o array para o dobro do tamanho original (8 elementos)
            Array.Resize(ref array, array.Length * 2);

            // Itera sobre os elementos do array e os imprime na tela
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            // Itera sobre os elementos do array usando um loop for e imprime a posição e o valor de cada elemento
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Posição Nº {i} - {array[i]}");
            }

        }
    }
}
