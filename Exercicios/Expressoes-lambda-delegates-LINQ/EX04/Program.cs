using System;
using EX04.Entities;

namespace Course
{

    //declaração do meu delegate
    //Esta especificando aqui, que ele vai ser uma referencia para uma função, que recebe dois numeros double
    //E retorna um numero double
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        public static int globalValue = 3;
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //Multicast
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);

        }

    }
}
