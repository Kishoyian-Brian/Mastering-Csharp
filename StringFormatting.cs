using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class StringFormatting
    {
        public static void Run()
        {
            string name = "Brian";
            int age = 22;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine();

            Console.WriteLine("Name: " + name + "\nAge: " + age);

            Console.WriteLine("Your name is Brian and your age is 22");
            Console.WriteLine("Your name is {0} and your age is {1}", name, age);
        }
    }
}