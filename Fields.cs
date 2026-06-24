using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Fields
    {
        public class Person
        {
            private string Name;
            private int Age;

            public void SetName(string name)
            {
                /*if (!string.IsNullOrEmpty(name))
                {
                    Name = name;
                }
                else
                {
                    Name = "Inavalid";
                } */

                Name = !string.IsNullOrEmpty(name) ? name : "Invalid";


            }
            public string GetName()
            {
                return Name;
            }

            public void SetAge(int age)
            {

                /*if (age > 0 && age <= 150)
                {

                    Age = age;
                }
                else
                {
                    Age = -1;
                }*/
                Age = age > 0 && age <= 150 ? age : -1;
            }

            public int GetAge()
            {
               return Age;
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }



            public string ReturnDetails()
            {
                return $"Name: {Name}\nAge: {Age}";
            }
        }
        public static void Run()
        {
            Person person = new Person("Brian", 22);

            System.Console.WriteLine(person.ReturnDetails());

            person.SetName("Mwas");
            System.Console.WriteLine(person.ReturnDetails());

            person.GetName();
            System.Console.WriteLine($"Your name is {person.GetName()}");

            person.SetAge(23);
            System.Console.WriteLine(person.ReturnDetails());

            person.GetAge();
            System.Console.WriteLine($"Your age is {person.GetAge()}");


        }
    }
}