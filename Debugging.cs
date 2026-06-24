using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Debugging
    {
        public static void Run()
        {
            int age = 35;

            if(age > 18)
            {
                System.Console.WriteLine("18+");
            } else if( age > 30)
            {
                System.Console.WriteLine("30+");
            }
        }
    }
}
