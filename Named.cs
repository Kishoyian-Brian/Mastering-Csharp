using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Named
    {
        public static void Run()
        {
            string nameInput =" Brian";
            int ageInput = 22;
            string addressInput = "100 SRoad";
            PrintDetails(age: ageInput,
                         name: nameInput, 
                         address: addressInput);
        }

        static void PrintDetails(string name, int age, string address)
        {
            System.Console.WriteLine($"{name} ");
            System.Console.WriteLine($"{age} ");
            System.Console.WriteLine($"{address} ");
        }
    }
}