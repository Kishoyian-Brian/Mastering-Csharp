using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class For
    {
        public static void Run()
        {
            // Console.WriteLine("Hi");
            // Console.WriteLine("Hi");
            // Console.WriteLine("Hi");
            // Console.WriteLine("Hi");
            // Console.WriteLine("Hi");

            Console.Write("What message do you wnat to print?:  ");
            string message = Console.ReadLine();

            Console.Write("How many Times do you wnat it to repeat?: ");
            int count = Convert.ToInt32(Console.ReadLine());

            if (count == 0)
            {
                Console.WriteLine("Please enter a valid number");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(message);
                }
            }

            // for(int i = 0; i<=10; i += 2)
            // {
            //     Console.WriteLine(i);
            // }
        }
    }
}