using System;
using System.Globalization;
using ProjetoContaBancaria.Entities;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contas;

            Console.Write("Entre com o número da conta: ");
            int Conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char response = char.Parse(Console.ReadLine());

            if(response == 's' || response == 'S')
            {
                Console.Write("Entre com um valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                contas =  new ContaBancaria(Conta, Titular, depositoInicial);
            }
            else
            {
                contas = new ContaBancaria(Conta, Titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contas);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            contas.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contas);

            Console.WriteLine();
            Console.Write("Entre com um valor para efetuar o saque: ");
            quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            contas.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contas);
        }
    }
}
