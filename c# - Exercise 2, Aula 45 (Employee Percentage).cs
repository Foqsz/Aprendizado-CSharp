using System;
using System.Globalization;

namespace Course
{
    internal class DadosF
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double Porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * Porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DadosF d = new DadosF(); 

            Console.Write("NOME: ");
            d.Nome = Console.ReadLine();
            Console.Write("SALARIO: ");
            d.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("IMPOSTO: ");
            d.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + d.Nome + " $ " + d.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d.AumentarSalario(Porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + d);
        }
    }
}
