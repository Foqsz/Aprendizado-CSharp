using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2024, 2, 21);
            DateTime d2 = new DateTime(2024, 2, 21, 08, 46, 50);
            DateTime d3 = new DateTime(2024, 2, 21, 08, 46, 50, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);



        }
    }
}

using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d3 = DateTime.Parse("15/08/2000");
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            DateTime dd1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime dd2 = DateTime.ParseExact("18/08/2015 06:30:15.006542", "dd/MM/yyyy HH:mm:ss.ffffff", CultureInfo.InvariantCulture);

            Console.WriteLine(dd1);
            Console.WriteLine(dd2);


        }
    }
}


// mais exemplos: https://learn.microsoft.com/en-us/dotnet/api/system.datetime.parseexact?view=net-8.0
