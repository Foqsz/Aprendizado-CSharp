using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Lista count: " + list.Count); //Para contar

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1); //Para pgar a primeira letra A

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);//para pegar a ultima letra A

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);//para pegar o primeiro nome com A e sua posição

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos2);//para pegar o segundo nome com A e sua posição

            List<string> list2 = list.FindAll(x => x.Length == 5);//para pegar um nome com +5 caracteres
            Console.WriteLine("-----------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");//Para remover alex da lista
            Console.WriteLine("--------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');//para remover todos com 'M' da lista
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
