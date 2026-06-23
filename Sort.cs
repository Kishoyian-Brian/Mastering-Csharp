using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Sort
    {
        public static void Run()
        {
            int[] numbers = new int[]
            {
                7,2,3,0,5,6,6,7,8,2
            };

            Array.Sort(numbers);
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}