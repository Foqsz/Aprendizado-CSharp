using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 To Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 To Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 To Utc: " + d3.ToUniversalTime());

            //Para Saber a data e hora atual
            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime);
            //

            DateTime d1s = DateTime.Parse("2000-08-15 13:05:58"); //unspecified
            DateTime d2s = DateTime.Parse("2000-08-15T13:05:58Z"); //local

            Console.WriteLine("d1: " + d1s);
            Console.WriteLine("d1 Kind: " + d1s.Kind);
            Console.WriteLine("d1 to Local: " + d1s.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1s.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2s);
            Console.WriteLine("d2 Kind: " + d2s.Kind);
            Console.WriteLine("d2 to Local: " + d2s.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2s.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2s.ToString("yyyy-MM-ddTHH:mm:ssZ")); //ISO 8601 UTC
            Console.WriteLine(d2s.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
          
        }
    }
}
