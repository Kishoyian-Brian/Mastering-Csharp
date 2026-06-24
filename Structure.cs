using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Structure
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthMonth;

            public Person(string name,int age, int birthMonth)
            {
                this.name = name;
                this.age = age;
                this.birthMonth=birthMonth;
            }
        }
        public static void Run()
        {
            // string name = "Brian";
            // int age=22;

            // Person person;

            // person.name = "brian";
            // person.age = 22;

            // System.Console.WriteLine($"Your name is {name} and your age is {age}"); 
            // System.Console.WriteLine();
            // System.Console.WriteLine($"Your name is {person.name} and your age is {person.age}");

            Person person = ReturnPerson();
            System.Console.WriteLine();
            System.Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");



        }

        static Person ReturnPerson()
        {
            System.Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Enter yourr birth month: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            // Person person;

            // person.name = name;
            // person.age = age;
            // person.birthMonth = birthMonth;

            return new Person(name,age,birthMonth);

        }

    }
}