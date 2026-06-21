using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Exercise
    {
        
        public static void Run()
        {
           int num1 = 34;
           int num2 = 4;

           var reminder = num1 % num2;

           System.Console.WriteLine(reminder);

           num1 = 40;
           reminder = num1 % num2;
           System.Console.WriteLine(reminder);

            Console.ReadLine();
        }
    }
}