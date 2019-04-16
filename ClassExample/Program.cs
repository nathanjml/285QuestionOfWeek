using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list = new List<int> { 3, 4, -1, 4, 5, 9, 10, 120, 2, 1, 0 };

            //partition should provide 2 collections: 
            //the first result containing everything less than or equal to 2
            //the second result containing everything greater than 2.
            //The usage is provided below.
            var (result, resulttwo) = list.Partition(x => x <= 2);
            foreach(var num in result)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("--------");
            foreach (var num in resulttwo)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
