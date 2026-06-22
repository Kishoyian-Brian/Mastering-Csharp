using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ExercisePaswordValidadtion
    {
        public static void Run()
        {
            System.Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            System.Console.WriteLine("Confirm your password: ");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if (password.Length >= 6 && passwordC.Length >= 6)
                    {

                        if (password.Equals(passwordC))
                        {
                            System.Console.WriteLine("Password Match");
                        }
                        else
                        {
                            System.Console.WriteLine("password dont match");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Password must be atleast 6 characters");
                    }
                }
                else
                {
                    System.Console.WriteLine("Please Confirm your password");
                }
            }
            else
            {
                System.Console.WriteLine("Enter a password");
            }


        }
    }
}