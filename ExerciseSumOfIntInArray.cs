using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ExerciseSumOfIntInArray
    {
        /*
            -create and initialose int array of numbers
            -craete function SumOfNumbers with int return type
            -int array param
            -function should return a total of all numbers
            -call in un and output the total
             --Extra check:-Check array lenght
                           -check in return in the run and output message
                           -do we need to return -1?, how else can we return this?
        */
        public static void Run()
        {
            int[] numbers = new int[]
            {
                1,2,3,4,5,6
            };

            int result = SumOfNumbers(numbers);

            if (result > -1)
            {
               System.Console.WriteLine($" The total is {result}");

            }
            else
            {
                System.Console.WriteLine("Cannot add up an empty array!");
            }

            // More efficient way because you dont know what the user can input: what if the array are ngative?
            //This will calculate also the negative values

            if(SumOfNumbers(numbers, out int total))
            {
                System.Console.WriteLine($" The total is {total}");
            }
            else
            {
                System.Console.WriteLine("Cannot add up an empty array!");
            }


        }

        static int SumOfNumbers(int[] numbers)
        {
            if(numbers.Length > 0)
            {
                
            int total =0;

            foreach (var item in numbers)
            {
                total += item;
            }

            return total;
            }
            return -1;
        }
        static bool SumOfNumbers(int[] numbers, out int total)
        {
            total =0;
            if(numbers.Length > 0)
            {
                

            foreach (var item in numbers)
            {
                total += item;
            }

            return true;
            }
            return false;
        }
    }
}