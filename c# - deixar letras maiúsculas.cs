
using System;

class Program
{
 static void Main()
 {
 string[] nomes = { "Vinicius", "Pedro" };
 string[] nomesMaiusculos = Array.ConvertAll(nomes, s => s.ToUpper());

 foreach (var nome in nomesMaiusculos)
 {
 Console.WriteLine(nome);
 }
 }
}
