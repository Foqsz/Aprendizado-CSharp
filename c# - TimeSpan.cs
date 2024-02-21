using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1); 
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            TimeSpan s1 = TimeSpan.FromDays(1.5);
            TimeSpan s2 = TimeSpan.FromHours(1.5);
            TimeSpan s3 = TimeSpan.FromMinutes(1.5);
            TimeSpan s4 = TimeSpan.FromSeconds(1.5);
            TimeSpan s5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan s6 = TimeSpan.FromTicks(900000000L);
              
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);

        }
    }
}
