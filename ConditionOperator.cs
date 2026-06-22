using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ConditionOperator
    {
        public static void Run()
        {
            int age = -10;

            if(age >= 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            string result = age >=0 ? "Valide":"Valid";
             Console.WriteLine(result);
        }
    }
}