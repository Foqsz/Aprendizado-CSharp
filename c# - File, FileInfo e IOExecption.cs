using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Windows\Temp\file1.txt";
            string targetPatch = @"C:\Windows\Temp\file2.txt"; 

            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPatch); 
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                } 
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

