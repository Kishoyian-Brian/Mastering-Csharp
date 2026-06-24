using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class OptionalParameter
    {
        public static void Run()
        {
            int result = Add(5);
            System.Console.WriteLine(result);
            
            PrinaName();
        }

        static void PrinaName(string name = "Brian")
        {
            Console.WriteLine($"My name is {name}");
        }

            static int Add(int a, int b = default)
        {
            return a+b;
        }
    }

}