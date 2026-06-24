using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Functions
    {
        public static void Run()
        {
            CreatePrintArray();
        }

        static void CreatePrintArray()
        {
            int[] numbers = new int[5]
            {
                1,2,3,4,5
            };
            foreach (var item in numbers)
            {
                System.Console.Write($"{item} ");
            }
        }
    }
}