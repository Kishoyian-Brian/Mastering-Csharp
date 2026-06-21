using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Var
    {
        public static void Run()
        {
            //int age = 23;
            var age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            //long bigNumber = 2626626226L;
            var bigNumber = 232323233L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            var negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            var precision = 5.00001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
        }
    }
}