using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class While
    {
        public static void Run()
        {
            // for(int i = 0;i<10; i++)
            // {
            //     Console.WriteLine(i);
            // }
            
            int i =0;
            while (i<10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}