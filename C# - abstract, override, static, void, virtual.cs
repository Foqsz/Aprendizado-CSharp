using System;

namespace Course
{
    // CLASSE ABSTRATA
    abstract class Veiculo
    {
        private string modelo;

        public Veiculo(string modelo)
        {
            this.modelo = modelo;
        }

        public virtual void Ligar()
        {
            Console.WriteLine($"O veículo {modelo} está ligado.");
        }

        public abstract void Mover();
    }

    // CLASSE DERIVADA 1
    class Carro : Veiculo
    {
        public Carro(string modelo) : base(modelo) { }

        public override void Ligar()
        {
            Console.WriteLine("Ligando o carro com a chave...");
        }

        public override void Mover()
        {
            Console.WriteLine("O carro está andando sobre rodas.");
        }
    }

    // CLASSE DERIVADA 2
    class Aviao : Veiculo
    {
        public Aviao(string modelo) : base(modelo) { }

        public override void Mover()
        {
            Console.WriteLine("O avião está voando pelos céus.");
        }
    }

    // CLASSE STATIC DE UTILIDADE
    static class VeiculoUtils
    {
        public static void MostrarLinha()
        {
            Console.WriteLine(new string('-', 40));
        }
    }

    // CLASSE PRINCIPAL
    class ProgramBeecrowd
    {
        static void Main(string[] args)
        {
            VeiculoUtils.MostrarLinha();
            Veiculo carro = new Carro("Fusca");
            carro.Ligar();
            carro.Mover();

            VeiculoUtils.MostrarLinha();
            Veiculo aviao = new Aviao("Boeing 737");
            aviao.Ligar(); // usa a versão da classe base
            aviao.Mover();

            VeiculoUtils.MostrarLinha();
        }
    }
}
