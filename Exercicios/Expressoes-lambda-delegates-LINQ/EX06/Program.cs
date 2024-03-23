using System;
using EX06.Entities;
using System.Collections.Generic;
using System.Data;

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

            /*Objeto tipo delegate action que recebe a referência da UpdatePrice
            Action<Product> act = UpdatePrice;
            list.ForEach(act);*/

            /*Exemplo com expressao lambda
            função que recebe o argumento p e ela para uma ação
            no caso dessa função precisamos colocar as chaves pois essa função não vai retornar nada
            Action<Product> act = p => { p.Price += p.Price * 0.1; }/
            */

            //ForEach função do list que recebe um Action, ou uma função void
            list.ForEach(UpdatePrice);
            foreach(Product p in list){
                Console.WriteLine(p);
            }

        }

         static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
