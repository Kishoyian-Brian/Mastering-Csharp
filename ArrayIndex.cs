using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public interface ArrayIndex
    {
        public static void Run()
        {
            int[] number = new int[]
            {
                1,2,4,5,6,7,7,
            };
            Console.Write("Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(number, search);

            if(position >= 0)
            {
                System.Console.WriteLine($"Number {search} has been found in position {position +1}");
            }
            else
            {
                System.Console.WriteLine($"Number {search} does not exist try another number!");
            }

           // int position = -1;
            // for (int i = 0; i < number.Length; i++)
            // {
            //     if(number[i] == search)
            //     {
            //         position = i;
            //     }
            //     if(position > -2)
            //     {
            //         System.Console.WriteLine($"Number {search} has been found at pisition {position}");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine($"Number {search} has not been found");
            //     }
            // }
        }
    }
}