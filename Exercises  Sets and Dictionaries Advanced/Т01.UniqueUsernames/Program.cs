using System;
using System.Collections.Generic;

namespace Т01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> userNames = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string username = Console.ReadLine();
                userNames.Add(username);
            }
            foreach (string username in userNames)
            {
                
                Console.WriteLine(username);
            }
        }
    }
}
