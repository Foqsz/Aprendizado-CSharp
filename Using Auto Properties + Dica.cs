using System;
using System.Globalization;


// Ordem correta:
// - Atributos Privados
// - Propriedades autoimplementadas
// - Construtores
// - Propriedades Customizadas
// - Outros métodos da Classe

namespace Course
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; } // Auto properties
        public int Quantidade { get; private set; } // Auto properties
        
        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
        }   }
         
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
               + ", $ "
               + Preco.ToString("F2", CultureInfo.InvariantCulture)
               + ", "
               + Quantidade
               + " unidades, Total: $ "
               + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

using Course;
using System;
using System.Globalization;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";
            
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);    
        }
    }
}
