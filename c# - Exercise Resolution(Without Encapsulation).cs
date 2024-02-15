using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Bancario
    {
        public double NumeroConta;
        public string Titular;
        public double Deposito;
        public string Resposta;
        public double saque;
        public double NewDeposito;
        public static double Taxa = 5.0;
        public bool DepositoInicial()
        {
            if (Resposta == "s")
            {
                return true;
            }

            else
            {  
                return false;
            }
        }
        public double NewDepositos()
        {
            return Deposito + NewDeposito;
        }
        public double saques()
        {
            return NewDepositos() - saque;
        }
        public double DepositoTaxa()
        {
            return saques() - Taxa;
        }
    }
}

using Course;
using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bancario cliente = new Bancario();

            Console.Write("Entre o número da conta: ");
            cliente.NumeroConta = double.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            cliente.Titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n) ");
            cliente.Resposta = Console.ReadLine();

            if (cliente.DepositoInicial())
            {
                Console.WriteLine("------------------------");
                Console.Write("Entre o valor de depósito inicial: ");
                cliente.Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("------------------------");
                Console.WriteLine("Dados da conta:");
                Console.WriteLine("Conta: {0}, Titular: {1}, Saldo: ${2} ", cliente.NumeroConta, cliente.Titular, cliente.Deposito.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("------------------------");
                Console.Write("Entre um valor para depósito: "); 
                cliente.NewDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Dados da Conta Atualizados:");
                Console.WriteLine("Conta: {0}, Titular: {1}, Saldo: ${2} ", cliente.NumeroConta, cliente.Titular, cliente.NewDepositos().ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("------------------------");
                Console.Write("Entre um valor para Saque: ");
                cliente.saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Dados da Conta Atualizados:");
                Console.WriteLine("Conta: {0}, Titular: {1}, Saldo: ${2} ", cliente.NumeroConta, cliente.Titular, cliente.DepositoTaxa().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("------------------------");
            }

            else
            {
                Console.WriteLine("Dados da Conta: ");
                Console.WriteLine("Conta: {0}, Titular: {1}, Saldo: ${2} ", cliente.NumeroConta, cliente.Titular, cliente.Deposito.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("------------------------");

                Console.Write("Entre um valor para depósito: ");
                cliente.Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Dados Atualizados: ");
                Console.WriteLine("Conta: {0}, Titular: {1}, Saldo: ${2} ", cliente.NumeroConta, cliente.Titular, cliente.Deposito.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("------------------------");

                Console.Write("Entre um valor para saque: ");
                cliente.saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("------------------------");
                Console.WriteLine("Dados Atualizados:");
                Console.WriteLine("Conta: {0}, Titular: {1}, Saldo: ${2} ", cliente.NumeroConta, cliente.Titular, cliente.DepositoTaxa().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("------------------------");
            }
        }
    }
}
