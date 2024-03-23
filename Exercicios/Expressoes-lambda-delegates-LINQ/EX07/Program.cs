using System;
using EX07.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*Como o método select retorna um IEnumerable, precisamos converter em list por isso o ToList
            Exemplo Select=>
            List<string> result = list.Select(NameUpper).ToList();
            */


            /*delegate que vai ser referencia para uma função
            Exemplo delegate=>
            Func<Product, string> func = NameUpper;

            List<string> result = list.Select(func).ToList();
            
            */

            /*Expressão lambda1
             Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(func).ToList();
            
            */

            //Expressão lambda inline
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

    }
}

