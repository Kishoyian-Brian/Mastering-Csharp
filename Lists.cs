using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    public class Lists
    {
        public static void Run()
        {
            int[] numbers = new int[4]
            {
                1, 2, 3, 4
            };

            List<int> listNumbers = new List<int>();

            for (int i =0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {      
                Console.WriteLine(listNumbers[i]);
            }
            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }


            
        }
    }
}