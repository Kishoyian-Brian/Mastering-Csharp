using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Constructor
    {
        /*struct Person
        {
            public string name;
            public int age;
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }*/

        class Person
        {
            public string Name;
            public int Age;

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
        }



        public static void Run()
        {
            Person person = new Person("Brian", 22);

            System.Console.WriteLine(person.Name);
            System.Console.WriteLine(person.Age);
        }
    }
}