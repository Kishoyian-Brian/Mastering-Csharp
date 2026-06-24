using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Ref
    {
        public static void Run()
        {
            int num = 10;
            Assign(ref num);
        }

        static void  Assign(ref int num)
        {
            num  = 20;
        }
    }
}