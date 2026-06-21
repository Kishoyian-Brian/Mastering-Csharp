using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Operations
    {
        public static void Run()
        {
        //  + - &*
            int age = 20 ;
            age += 10;
            Console.WriteLine(age);

            double div = 23;
            div /= 10;
            Console.WriteLine(div);
              
            string name = "csharp ";
            name += "is a progrmming language";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            System.Console.WriteLine(ch);  



            Console.ReadLine();
        }
    }
}