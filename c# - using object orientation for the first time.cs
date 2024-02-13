
namespace yes
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;
    }
}


using System;
using System.Globalization;

namespace yes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa A = new Pessoa();
            Pessoa B = new Pessoa();

            Console.WriteLine("Dados da Primeira Pessoa:");
            Console.Write("Nome: ");
            A.Nome = Console.ReadLine();

            Console.Write("Idade: "); 
            A.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda Pessoa:");
            Console.Write("Nome: ");
            B.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            B.Idade = int.Parse(Console.ReadLine());

            if (A.Idade > B.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + A.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + B.Nome);
            }
        }
    }
}
