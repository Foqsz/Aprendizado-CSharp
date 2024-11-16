using System;
using System.IO;

class LerArquivo
{
    static void Main(string[] args)
    {
        string caminhoArquivo = @"C:\caminho\para\arquivo.txt";

        try
        {
            string conteudo = File.ReadAllText(caminhoArquivo);
            Console.WriteLine(conteudo);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}