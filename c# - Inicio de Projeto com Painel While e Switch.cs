using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dados;
            bool exibirPainel = true;

            while (exibirPainel)
            {
                Console.WriteLine();
                Console.WriteLine("Olá, cliente! Digite a opção que você deseja: ");
                Console.WriteLine("1 - [Painel Bebidas]");
                Console.WriteLine("2 - [Painel Alimento]");
                Console.WriteLine("3 - [Painel Doces]");
                Console.WriteLine("4 - [Fechar Painel]");

                dados = Console.ReadLine();

                switch (dados)
                {
                    case "1":
                        Console.WriteLine("Essas são as nossas bebidas disponíveis: ");
                        break;

                    case "2":
                        Console.WriteLine("Temos bastantes alimentos disponíveis. Confira a lista:");
                        break;
                    case "3":
                        Console.WriteLine("Se você deseja algo doce, como bombom ou trufas, confira nosso painel completo:");
                        break;
                    case "4":
                        Console.WriteLine("Ok. O Painel será fechado! Obrigado e volte sempre.");
                        exibirPainel = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Você deve teclar entre 1-4.");
                        exibirPainel = true;
                        break;

                }
            }
        }
    }
}
