using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class If
    {
        public static void Run()
        {
            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
            // Console.Write("Enter your age: ");
            // string ageInput = Console.ReadLine();
            // int age = Convert.ToInt32(ageInput);
            // Console.WriteLine($"Hello {name} ");
            // Console.WriteLine($"You are {age} years old.");


            // if (age < 0 || age > 150)
            // {
            //     Console.WriteLine("Invalid Age!");
            // }
            // else
            // {
            //     if (age >= 18 && age <= 24)
            //     {
            //         Console.WriteLine("Your are grouped between 18 and 24");
            //     }
            //     else if (age >= 25)
            //     {
            //         Console.WriteLine("Your 25 or older");
            //     }
            // }

            Console.Write("Enter the first number: ");
            string num1Input = Console.ReadLine();
            int numA = Convert.ToInt32(num1Input);

            Console.Write("Enter the first number: ");
            string num2Input = Console.ReadLine();
            int numB = Convert.ToInt32(num2Input);

            int answer = numA * numB;

            Console.Write("Value of " + numA + " * " + numB  + " is :"  );
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput); 

            if(answer == actualAnswer)
            {
                Console.Write("Congratulation!");
            }
            else
            {
                Console.Write("Almost there. Try Again!!");
            }
        }
    }
}