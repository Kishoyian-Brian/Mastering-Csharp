using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class StringInterpolation
    {
        public static void Run()
        {
            string name = "Brian";
            int age = 22;

            Console.WriteLine("Your name is {0} and your age is {1}", name, age);
            
            Console.WriteLine($"Your name is {name} and your age is {age}");      
        }
    }
}