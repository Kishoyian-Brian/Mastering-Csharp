using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp

       /*   -Define and initialise two interger (num, length)
            -(7,5) -> [7,14,21,28,35]
            -create int with array size lenght
            -Loop through and insert the (loop counter x num) into the array
            - print the finanal array
         */

{
    public class ExerciseArrayOfMultiple
    {
        public static void Run()
        {
            int num = 7;
            int length = 5;

            int[] result =new int[length];

            int counter = 0;

            for (int i = 1; i <= result.Length; i++)
            {
                result[counter] = num * i;
                counter ++;
            }
            foreach (var item in result)
            {
                System.Console.Write($"{item} ");
            }

        }
    }
}