using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class IsNullOrIsEmpty
    {
        public static void Run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");

            // if(name != "")
            // {
            //     System.Console.WriteLine("0");
            // }

            // if (!name.Equals(""))
            // {
            //     System.Console.WriteLine("1");
            // }

            if (!string.IsNullOrEmpty(name))
            {
                System.Console.WriteLine("2");
            }
        }
    }
}