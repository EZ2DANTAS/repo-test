using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Matheus",1000, 10);

            p.Nome = "T";
            Console.WriteLine(p.Nome);

           
        }
    }
}
