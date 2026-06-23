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
        }
    }
}