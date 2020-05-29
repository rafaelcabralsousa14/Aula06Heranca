using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF individuo = new CPF();
            individuo.nome = "Rafael";
            Console.WriteLine(individuo.Saudar());
            individuo.cpf = "42113562839";
            individuo.rg = "3.021.415";
            Console.WriteLine(individuo.ValidarCPF());

        }
    }
}
