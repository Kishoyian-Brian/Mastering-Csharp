using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Concanation
    {
        public static void Run()
        {
            string name = "Brian";
            int age = 22;
            string test = string.Concat("Your name is ", name, " and your age is " ,age);
            Console.WriteLine(test);
        }
    }
}