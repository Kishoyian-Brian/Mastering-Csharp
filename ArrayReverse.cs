using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ArrayReverse
    {
        public static void Run()
        {
            int[] numbers = new int[]
            {
                0,1,2,3,4,5,6,7,8,9
            };

            int[] sortedNum = new int[numbers.Length];
            int x = 0;
            for (int i = numbers.Length - 1; i >= 0 ; i--)
            {
                sortedNum[x]=numbers[i];
                x++;
            }
            foreach (var num in sortedNum)
            {
                System.Console.Write($"{num} ");
            }
            // Array.Reverse(numbers);

            // foreach (int num in numbers)
            // {
            //     System.Console.Write($"{num} ");
            // }
        }
    }
}