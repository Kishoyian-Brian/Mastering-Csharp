using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ExerciseTimetable
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",i,number,i*number);
            }
        }
    }
}