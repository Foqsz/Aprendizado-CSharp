using System;
using System.IO;
//https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-8.0&redirectedfrom=MSDN
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Windows\Temp\file1.txt";
            string targetPath = @"C:\Windows\Temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
