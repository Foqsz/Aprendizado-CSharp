using System;
using System.IO;
using System.Collections.Generic;

namespace Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitando o número de alunos para o curso A
            Console.Write("Quantos alunos para o curso A? ");
            int entradaA = int.Parse(Console.ReadLine());

            // Criando um conjunto para armazenar os IDs dos alunos do curso A
            HashSet<string> alunosA = new HashSet<string>();
            for (int i = 1; i <= entradaA; i++)
            {
                // Solicitando e adiciona o ID do aluno ao conjunto do curso A
                Console.Write($"Informe o ID do aluno {i} no curso A: ");
                string cursoA = Console.ReadLine();
                alunosA.Add(cursoA);
            }

            // Solicitando o número de alunos para o curso B
            Console.Write("Quantos alunos para o curso B? ");
            int entradaB = int.Parse(Console.ReadLine());

            // Criando um conjunto para armazenar os IDs dos alunos do curso B
            HashSet<string> alunosB = new HashSet<string>();
            for (int i = 1; i <= entradaB; i++)
            {
                // Solicitando e adiciona o ID do aluno ao conjunto do curso B
                Console.Write($"Informe o ID do aluno {i} no curso B: ");
                string cursoB = Console.ReadLine();
                alunosB.Add(cursoB);
            }

            // Solicitando o número de alunos para o curso C
            Console.Write("Quantos alunos para o curso C? ");
            int entradaC = int.Parse(Console.ReadLine());

            // Criando um conjunto para armazenar os IDs dos alunos do curso C
            HashSet<string> alunosC = new HashSet<string>();
            for (int i = 1; i <= entradaC; i++)
            {
                // Solicitando e adicionando o ID do aluno ao conjunto do curso C
                Console.Write($"Informe o ID do aluno {i} no curso C: ");
                string cursoC = Console.ReadLine();
                alunosC.Add(cursoC);
            }

            // Unindo os conjuntos de alunos de todos os cursos em um único conjunto
            HashSet<string> uniqueStudents = new HashSet<string>(alunosA);
            uniqueStudents.UnionWith(alunosB);
            uniqueStudents.UnionWith(alunosC);

            // Exibir o total de alunos únicos nos três cursos
            Console.WriteLine("Total de Alunos: " + uniqueStudents.Count);
        }
    }
}
