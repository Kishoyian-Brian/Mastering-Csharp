using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MyConsoleApp
{
    public class ConsoleIO
    {
        public static void Run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Hello {name} ");
            Console.WriteLine($"You are {age} years old.");

            Console.ReadLine();
        }
    }
}