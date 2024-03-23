using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double circ = Circuferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circuferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio) 
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        
        
        }

    }
}