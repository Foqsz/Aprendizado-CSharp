using System;
using System.Globalization;

namespace Course
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        private int _pesssoa;
        public Produto()
        {  

        }  
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _quantidade = quantidade;
            _preco = preco;
        }   

        public void SetNome(string nome) 
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
            
        }
        public string GetNome()
        {
            return _nome;
        }
        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade() 
        {
            return _quantidade;        
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        /////A aula só foi até acima
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
               + ", $ "
               + _preco.ToString("F2", CultureInfo.InvariantCulture)
               + ", "
               + _quantidade
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

            p.SetNome("T");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());    
        }
    }
}

////Modificações de encapsulamento abaixo
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

            p.SetNome("T");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());    
        }
    }
}
