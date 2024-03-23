using System;
using System.Globalization;
using  EX07.Entities;

namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alunoX = new Aluno();
            Console.Write("Nome do aluno: ");
            alunoX.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            alunoX.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            alunoX.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            alunoX.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("NOTA FINAL = " + alunoX.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));

            if (alunoX.Aprovacao())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " 
                    + alunoX.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) 
                    + " PONTOS") ;
            }
        }

    }
}