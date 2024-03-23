using System;
using Curse;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas PessoaX, PessoaY;
            PessoaX = new Pessoas();
            PessoaY = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            PessoaX.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            PessoaX.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            PessoaY.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            PessoaY.Idade = int.Parse(Console.ReadLine());


            if (PessoaX.Idade > PessoaY.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + PessoaX.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + PessoaY.Nome);    
            }
        }

    }
}