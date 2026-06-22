using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class EqualStrings
    {
        public static void Run()
        {
            string message = "Hello";
            string compare = "Hello";

            if (message == compare)
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            //if(name != string.Empty)
            if(!name.Equals(string.Empty))
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Inavlid input");
            }
        }
    }
}