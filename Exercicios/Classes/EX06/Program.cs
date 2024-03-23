using System;
using System.Globalization;
using  EX06.Entities;

namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario pessoa1 = new Funcionario();
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            pessoa1.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            pessoa1.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + pessoa1);

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            pessoa1.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + pessoa1);

        }

    }
}