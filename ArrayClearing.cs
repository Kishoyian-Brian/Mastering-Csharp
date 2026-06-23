using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ArrayClearing
    {
        public static void Run()
        {
            int[] numbers = new int[]
            {    
            0,1,2,3,4,5,6,7,8,9
            };

           // Array.Clear(numbers,0,numbers.Length);

          Array.Clear(numbers,5,5);  // this reset he value to the default value which is 0;
          for (int i = 5; i < 10; i++)
           {
             numbers[i] = 0;
           }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}