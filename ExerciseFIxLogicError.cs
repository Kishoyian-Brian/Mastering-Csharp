using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ExerciseFIxLogicError
    {
        public static void Run()
        {
             int age = 35;

             if( age > 18 && age <30)
            {
                System.Console.WriteLine("over 18");
            
            }
            else if(age > 30 && age < 50)
            {
                System.Console.WriteLine("over 30");
            }
            else if(age > 50)
            {
                System.Console.WriteLine("over 50");
            }
        }
    }
}