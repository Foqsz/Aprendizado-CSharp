using System;
using System.Globalization;
using System.Security.Principal;
using Course.Entities;
using Course.Entities.Exceptions;
//continuação está no meu outro repositorio
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<AccountEx> accounts = new List<AccountEx>();

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int Number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string Holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double Balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Enter amount for withdraw: ");
                double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                AccountEx account = new AccountEx(Number, Holder, Balance, withdrawLimit);
                account.Deposit(withdrawAmount);
                accounts.Add(account);

                Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture)); 
            }
            catch (AccountException erro)
            {
                Console.WriteLine("Withdraw error: " + erro.Message);
            }
            catch (Exception erro)
            {
                Console.WriteLine("Withdraw error: " + erro.Message);
            } 
        }
    }
}

