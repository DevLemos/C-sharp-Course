using System;
using System.Linq;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Especificar o seu data source
            int [] numbers = new int[] { 2, 3, 4, 5};

            /*
            Define query expression
            var result = numbers
            .Where(x => x % 2 == 0)
            .Select(x => x * 10);
            */

            /*
            Define query expression
            IEnumerable<int> result = numbers
            .Where(x => x % 2 == 0)
            .Select(x => x * 10);
            */

            List<int> result = numbers
            .Where(x => x % 2 == 0)
            .Select(x => x * 10)
            .ToList();

            //Excutar query
            foreach(int x in result){
                Console.WriteLine(x);
            }
        }
    }
}
