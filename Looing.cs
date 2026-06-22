using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace MyConsoleApp
{
    public class Looing
    {
        public static void Run()
        {
            string mess = "C# is a programming language";


            Console.WriteLine(mess[0]);
            Console.WriteLine(mess[1]);
            Console.WriteLine(mess[2]);
            Console.WriteLine(mess[3]);

            for (int i = 0; i < mess.Length; i++)
            {
                Console.Write(mess[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine(mess.Contains("#"));

            bool contains = false;
            for (int i = 0; i < mess.Length; i++)
            {
                if (mess[i].Equals('F'))
                {
                    contains = true;
                }
            }
            Console.WriteLine(contains);
        }
    }
}