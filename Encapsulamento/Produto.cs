using System;
using System.Globalization;

namespace Encapsulamento
{
    internal class Produto
    {

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
           _nome = nome;
           Preco = preco;
           Quantidade = quantidade;
        }

        //Inico de Propriedades --------------------
        public string Nome
        {
            get { return _nome; }
            set{
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        //Fim das Propriedades --------------------


        //INICIO AÇÕES 
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;

        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        //FIM AÇÕES


        //INICIO TO STRING
        public override string ToString()
        {
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + " Quantidade no estoque: " + Quantidade + " , Valor Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        // FIM TO STRING

    }
}