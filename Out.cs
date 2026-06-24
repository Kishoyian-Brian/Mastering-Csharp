using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    public class Out
    {
        public static void Show()
        {
            int num = 0;
            Test(out num);
            System.Console.WriteLine(num);

            List<string> shoppingList = new List<string> { "bread", "milk", "eggs" };
            if (FindInList("milk", shoppingList, out int index))
            {
                System.Console.WriteLine($"Found milk at index {index}");
            }
            else
            {
                System.Console.WriteLine("Not found");
            }
        }

        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                    break;
                }
            }

            bool found = index > -1;
            return found;
        }

        static bool TryParse(string s, out int result)
        {
            result = 0;
            return int.TryParse(s, out result);
        }

        static void Test(out int num)
        {
            num = 5;
        }
    }
}
