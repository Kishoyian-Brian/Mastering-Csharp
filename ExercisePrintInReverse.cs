using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ExercisePrintInReverse
    {
        public static void Run()
        {
            Console.Write("Enter Your message: ");
            string message = Console.ReadLine();



            // System.Console.WriteLine(message[0]);
            // System.Console.WriteLine(message.Length);

            for (int i =0; i< message.Length; i++)
            {
                System.Console.Write(message[i]);
            }

            for (int i = message.Length -1; i >= 0; i--)
            {
                System.Console.Write(message[i]);
            }
        }
    }
}