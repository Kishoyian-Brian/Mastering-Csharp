using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class TryParse
    {
        public static void Run()
        {
            bool success = true;

            while (success)
            {
                Console.Write("Enter a number: ");
                string inputNum = Console.ReadLine();



                if (int.TryParse(inputNum, out int num))
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert");
                }

                Console.WriteLine(num);
            }
        }


    }
}
