using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Triangles
    {
        public static void Run()
        {
            const int anglesCount = 3;
            int[] angles = new int[anglesCount];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter the angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;
            foreach (int angle in angles)
            {
                angleSum += angle;
            }
            System.Console.WriteLine(angleSum);

            System.Console.WriteLine(angleSum ==180 ? "valid" : "Invalid!");


        }
    }
}