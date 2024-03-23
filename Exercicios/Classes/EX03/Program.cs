using System;
using System.Globalization;
using EX03.Entities;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios PessoaX, PessoaY;
            PessoaX = new Funcionarios();
            PessoaY = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            PessoaX.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            PessoaX.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            PessoaY.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            PessoaY.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = (PessoaX.Salario + PessoaY.Salario) / 2.0;

            Console.WriteLine("Salário médio =  " + media.ToString("F2",CultureInfo.InvariantCulture));
           
        }

    }
}
