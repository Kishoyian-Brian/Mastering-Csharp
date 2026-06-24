using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Dictionary
    {
        public static void Run()
        {
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                { 1, "Brian" },
                { 2, "mwas" },
                { 3, "funda" }
            };

            /*for (int i = 0; i < names.Count; i++)
            {
               KeyValuePair<int, string> pair = names.ElementAt(i);
               System.Console.WriteLine($"{pair.Key}-{pair.Value}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<int, string> items in names)
            {
                Console.WriteLine($"{items.Key}-{items.Value}");
            }*/

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
              {"math","Brian"},
              {"English","Mwas"}  
            };

            //System.Console.WriteLine(teachers["math"]);
            
            if(teachers.TryGetValue("math", out string teacher))
            {
                Console.WriteLine(teacher);

            }
            else
            {
                System.Console.WriteLine("Math teacher not found");
            }

            if (teachers.ContainsKey("math"))
            {
                teachers.Remove("math");
            }
            else
            {
                System.Console.WriteLine("maths not found");
            }

        }
    }
}