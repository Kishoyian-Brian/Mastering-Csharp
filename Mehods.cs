using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Mehods
    {
        class Person
        {
            public string Name;
            public int Age;

            public  Person(string name, int age)
            {
                this.Name = name;
                this.Age=age;
            }

            public string ReturnDetails()
            {
                return $"Name {Name}\nAge {Age}";
            }


        }
        public static void Run()
        {
            
            Person person = new Person("brian",22);

            // System.Console.WriteLine($"name{person.Name}");
            // System.Console.WriteLine($"name{person.Age}");

            System.Console.WriteLine();

            System.Console.WriteLine(ReturnDetails(person));
            System.Console.WriteLine();
            System.Console.WriteLine(person.ReturnDetails());

        }

        static string ReturnDetails(Person person)
        {
            return $"Name{person.Name}\nAge {person.Age}";
        }

        // static string ReturnDetails(string name, int age)
        // {
        //     return $"Name: {name}\nAge{age}";
        // }
    }
}