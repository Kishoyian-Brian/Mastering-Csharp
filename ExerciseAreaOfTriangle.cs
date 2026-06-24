using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ExerciseAreaOfTriangle
    {
        /*
            -ask user height and width and store them
            -create a function to calculate the area 
            -function should calculate the area using (width x height)/2
            -call in the main and print out the area
        */
        public static void Run()
        {
            int width = ReadInt("Enter width: ");
            int height =  ReadInt("Enter height: ");
            
            double result = CalcArea(width, height);

            System.Console.WriteLine($"The area is {result}");
        }

        static double CalcArea(double width, double height)
        {
            
            return (width * height) / 2;
        }

        static int ReadInt(string message)
        {
            System.Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}