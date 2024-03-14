using System;
using System.IO;
// https://learn.microsoft.com/en-us/dotnet/api/system.io.fileinfo?view=net-8.0&redirectedfrom=MSDN
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\file1.txt"; 
            StreamReader sr = null;

            try
            { 
                sr = File.OpenText(path);   
                while (!sr.EndOfStream) //enquanto (while) não chegar no final do stream, sera executaod.
                {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                } 
            }
            catch (IOException e)
            {
                Console.WriteLine("An error acurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();  
            }
        }
    }
}
