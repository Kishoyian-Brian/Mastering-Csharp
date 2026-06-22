using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace MyConsoleApp
{
    public class Format
    {
        public static void Run()
        {
            double value = 1000D / 12.35D;

            Console.WriteLine(value);

            Console.WriteLine(string.Format("{0:0.00}",value));

            double money = -10D / 3D;

            System.Console.WriteLine(money);
            System.Console.WriteLine(money.ToString("C"));
             System.Console.WriteLine(money.ToString("C0"));
              System.Console.WriteLine(money.ToString("C1"));
               System.Console.WriteLine(money.ToString("C2"));

              System.Console.WriteLine(money.ToString("C",CultureInfo.CurrentCulture)); 

              System.Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-GB"))); 
              System.Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-KE")));




        }
    }
}