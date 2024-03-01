//as classes estao no meu outro repositorio c-sharp-basic
using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine()); // usaremos a variavel char para responder a pergunta acima, y ou n.
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y') // leitura: se a variavel ch for igual a letra y em 'ch', ele vai ler.
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list) // para cada funcionario(employee emp) na minha lista list
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
 
