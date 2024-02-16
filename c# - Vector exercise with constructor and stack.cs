
namespace Course
{
    internal class Comercio
    {
        public string Name { get; set; }
        public string Email { get; set; }


        public Comercio(string name, string email) //construtor definido
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}

using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Comercio[] vect = new Comercio[10]; 

            Console.Write("Quantos quartos serão alugados?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Comercio(nome, email); //Aqui inicia o construtor, apos ter definido acima
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]); //aqui mostra o construtor
                }
            }
        }
    }
}
