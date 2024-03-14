/*
Directory
• static members (simple, but performs security check for each operation)
• https://msdn.microsoft.com/en-us/library/system.io.directory(v=vs.110).aspx
• DirectoryInfo
• instance members
• https://msdn.microsoft.com/en-us/library/system.io.directoryinfo(v=vs.110).aspx 
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\myfolder"; 

            try
            {
                //posso usar tanto list (comentado abaixo) quanto var, ambos funcionam.
                /*IEnumerable<string>*/ var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
