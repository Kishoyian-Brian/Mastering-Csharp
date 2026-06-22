using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class FizzBuzz
    {
        public static void Run()
        {
            bool threeDiv = false;
            bool fiveDiv = false;
            

            for(int i = 1; i <= 15; i++)
            {
                threeDiv= i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if(threeDiv && fiveDiv )
                {
                    Console.WriteLine("FizzBuzz");
                }else if(threeDiv)
                {
                    Console.WriteLine("Fizz");
                }else if(fiveDiv )
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}