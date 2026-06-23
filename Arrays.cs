using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Arrays
    {
        public static void Run()
        {
            int num1 =5;
           int num2=10;
           int num3=20;
           
           int[] number = new int[3];
        


        //    Console.Write("Enter a number: ");
        //    number[0] = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Enter the second Number: ");
        //    number[1] = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Enter the third number: ");
        //    number[2] = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine($"{num1},{num2},{num3}");
        //    Console.WriteLine($"{number[0]},{number[1]},{number[2]}");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("Enter a number: ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"{number[1]}");
            }
            foreach(int num in number)
            {
                Console.Write($"{num}");
            }
        }
    }
}