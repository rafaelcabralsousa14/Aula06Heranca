using System;

namespace Método_construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto sapato = new Produto();
            
            Produto chinelo = new Produto(0122223);
            System.Console.WriteLine(chinelo.Codigo);

            Produto tenis = new  Produto(12223, "tenis", "calçado", 100);
            
        }
    }
}
