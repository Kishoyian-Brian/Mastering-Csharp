using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Switch
    {
        public static void Run()
        {
            Console.Write("Enter a day of the week");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day == 1)
            {
                Console.WriteLine("Sun");
            }else if(day == 2)
            {
                Console.WriteLine("Mon");
            }

            switch (day)
            {
                case 1:Console.WriteLine("Tue");
                  break;
                case 2 : Console.WriteLine("Mon")  ;
                   break;
                case 3: Console.WriteLine("Tue");
                   break;
                case 4 : Console.WriteLine("Wed");
                   break;
                case 5: Console.WriteLine("Thur");
                   break;
                case 6 : Console.WriteLine("Friday");
                   break;
                case 7 :Console.WriteLine("Sat");
                  break;   
                default:Console.WriteLine("Enter a valid number 1-7"); //  same as else keywork
                  break;              
            }
        }
    }
}