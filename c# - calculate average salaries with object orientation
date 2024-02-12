
namespace xx
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;
    }
}


using System;
using System.Globalization;

namespace xx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario A = new Funcionario();
            Funcionario B = new Funcionario();

            Console.WriteLine("Dados da Primeira Pessoa:");
            Console.Write("Nome: ");
            A.Nome = Console.ReadLine();

            Console.Write("Salario: "); 
            A.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da Segunda Pessoa:");
            Console.Write("Nome: ");
            B.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            B.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media;

            media = (A.Salario + B.Salario) / 2;
            Console.WriteLine("Salario Medio: " + media);

        }
    }
}
