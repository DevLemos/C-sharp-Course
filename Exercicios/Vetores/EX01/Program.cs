using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de valores que deseja: ");
            int n = int.Parse(Console.ReadLine());
            //inicialização do vetor
            double[] vect = new double[n];
           //acrescentando os valores que o usuario digitou
            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            //percorrendo o vetor e colocando todos os valores do vetor na variável soma
            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            //variável para fazer a divisão dos valores 
            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}