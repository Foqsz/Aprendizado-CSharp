 
using System.Globalization;
using Course.Entities; 
// as classes estão no meu outro repositorio 
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPlayer> person = new List<TaxPlayer>();

            Console.Write("Enter the number of tax players: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax player #{i} data:");
                Console.Write("Individual or company (c/i) ? ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string Name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double Anual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double Heath = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    person.Add(new LegalPerson(Name, Anual, Heath));
                }

                else
                {
                    Console.Write("Name: ");
                    string Name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double Anual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    person.Add(new PhysicalPerson(Name, Anual, employees));

                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPlayer tp in person)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
