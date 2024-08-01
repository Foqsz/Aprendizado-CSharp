using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nJogadores = int.Parse(Console.ReadLine());
            double saques = 0, bloqueios = 0, ataques = 0;
            double saquesB = 0, bloqueiosB = 0, ataquesB = 0;

            for (int i = 0; i < nJogadores; i++)
            {
                Console.ReadLine(); // Aqui no caso seria a string[] inicial, mas foi ignorado. Eu poderia utilizar string A e armazenar, mas nao quis
                var tentativas = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); ///aqui cria e armazena as entradas
                var sucesso = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // o mesmo aqui

                saques += tentativas[0]; //ja aqui, como foi armazenado acima, de acordo com o looping, na posição [0], e como foi usado 3 vezes (N), armazenou o resto nas tentativas abaixo
                bloqueios += tentativas[1];
                ataques += tentativas[2];

                saquesB += sucesso[0]; //mesmo detalhamento acima
                bloqueiosB += sucesso[1];
                ataquesB += sucesso[2];
            }

            double calcPorcentagem(double sucesso, double tentativa) => tentativa == 0 ? 0 : (sucesso / tentativa) * 100; //aqui utilizo a expressão lambda para calcular, caso não for 0, executa a soma que vai vir do calcPorcentagem

            Console.WriteLine($"Pontos de Saque: {calcPorcentagem(saquesB, saques).ToString("F2", CultureInfo.InvariantCulture)} %.");
            Console.WriteLine($"Pontos de Bloqueio: {calcPorcentagem(bloqueiosB, bloqueios).ToString("F2", CultureInfo.InvariantCulture)} %.");
            Console.WriteLine($"Pontos de Ataque: {calcPorcentagem(ataquesB, ataques).ToString("F2", CultureInfo.InvariantCulture)} %.");
        }
    }
}
