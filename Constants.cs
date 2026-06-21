using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Constants
    {
        public static void Run()
        {
            const int vat = 20;
            System.Console.WriteLine(vat);
            const double percentVAT = vat / 100D;
            int bal = 1000;
            System.Console.WriteLine(bal * percentVAT);

            const string version = "v1.0";
            System.Console.WriteLine(version);

            Console.ReadLine();
        }
    }
}