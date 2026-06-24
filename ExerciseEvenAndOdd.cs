using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ExerciseEvenAndOdd
    {
        public static void Run()
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if(i%2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }
            System.Console.WriteLine("Printing even numbers: ");

            foreach (var item in even)
            {
                Console.Write(item);
            }

            System.Console.WriteLine("Printing odd numbers: ");

               foreach (var item in odd)
            {
                Console.Write(item);
            }


        }
    }
}