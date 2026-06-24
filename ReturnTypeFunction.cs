using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ReturnTypeFunction
    {
        public static void Run()
        {
            Console.WriteLine($"{ReturnName()} - {RetrunAge()}");
        }

        static string ReturnName()
        {
            return "Brian";
        }
          static int RetrunAge()
        {
            return 22;
        }
    }
}