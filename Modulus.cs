using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Modulus
    {
        public static void Run()
        {
            int firstNum = 10;
            int secondNum = 3;

            //10%2 = 0  -- Even 
            // 11 % 2 = 1 --- Odd


            System.Console.WriteLine(firstNum%secondNum); //3.333

            Console.ReadLine();
        }
    }
}