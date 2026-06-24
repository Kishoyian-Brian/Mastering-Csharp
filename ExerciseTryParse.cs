using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ExerciseTryParse
    {
        /*
           -create an int and try convert any string to an int
           -notice the error while a try catch handler around it
           -catch the error and output the error message
           -without changing the current code
              ---why this is a bad situation and how can we know if its been converted?
           -create a custom try parse function
           -find the real function and copy the return type/param
           -Read the toolti it give you, to give you ideas on what to do   

        */
        public static void Run()
        {
           /* bool success = false;
            try
            {

                System.Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                success = false;

            }
            catch (FormatException e)
            {
                System.Console.WriteLine(e.Message);
            }

            System.Console.WriteLine(success ? "Yes" : "No");
            */

            if(TryParse(Console.ReadLine(), out int result))
            {
                System.Console.WriteLine("Yey " + result);
            }
            else
            {
                System.Console.WriteLine("oh no!");
            }
             

        }

        static bool TryParse(string input, out int result)
        {
            result = -1;

            try
            {
                
            result = Convert.ToInt32(input);
            return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

    }
}