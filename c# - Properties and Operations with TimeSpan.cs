using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliSeconds: " + t.TotalMilliseconds);

            TimeSpan t1s = new TimeSpan(1, 30, 10);
            TimeSpan t2s = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1s.Add(t2);
            TimeSpan diff = t1s.Subtract(t2s);
            TimeSpan mult = t2s.Multiply(2.0);
            TimeSpan div = t2s.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(diff);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
