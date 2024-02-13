using System;
using System.Globalization;

namespace Course
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (Aprovado())
                return 0.0;
            else
            {
                return 60.0 - NotaFinal();
            }
        }

    }
}

using System; 
using System.Globalization; 

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aln = new Aluno();

            Console.Write("Nome do Aluno: ");
            aln.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");
            aln.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aln.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aln.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL: " + aln.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(aln.Aprovado());

            if (aln.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aln.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
        
    

