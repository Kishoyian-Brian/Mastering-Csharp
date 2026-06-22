using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class EmptyString
    {
        public static void Run()
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            if (name != string.Empty)
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Your name is empty!!");
            }
        }
    }
}