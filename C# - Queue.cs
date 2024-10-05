using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criação de uma fila de inteiros
        Queue<int> fila = new Queue<int>();

        // Adicionando elementos à fila
        fila.Enqueue(10);
        fila.Enqueue(20);
        fila.Enqueue(30);

        // Exibindo o primeiro elemento sem removê-lo
        Console.WriteLine($"Primeiro elemento: {fila.Peek()}"); // Saída: 10

        // Removendo o primeiro elemento da fila
        Console.WriteLine($"Elemento removido: {fila.Dequeue()}"); // Saída: 10

        // Exibindo a fila restante
        Console.WriteLine($"Novo primeiro elemento: {fila.Peek()}"); // Saída: 20

        // Verificando a quantidade de elementos
        Console.WriteLine($"Tamanho da fila: {fila.Count}"); // Saída: 2
    }
}
