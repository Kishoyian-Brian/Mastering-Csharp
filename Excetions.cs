using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Excetions
    {
        public static void Run()
        {

            //FormatException
            //OverFlowException

            bool looping = true;

            while (looping)
            {
                try
            {
                System.Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine(num);
                looping = false;

            }
            
            catch (System.Exception e)
            {
                System.Console.WriteLine($"Error: {e.Message}");
            }
                
            }

        }

    }
}