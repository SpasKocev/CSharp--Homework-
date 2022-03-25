using System;
using System.Linq;

namespace T02.SetsOfElements
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int[] lends = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstHashSet = new HashSet<int>();
            HashSet<int> secondHashSet = new HashSet<int>();
            Filset(firstHashSet, lends[0]);
            Filset(secondHashSet, lends[1]);
            CheckSet(firstHashSet, secondHashSet);
        }
       
        private static void CheckSet(HashSet<int> firstHashSet, HashSet<int> secondHashSet)
        {
            List<int> nums = new List<int>();
            foreach (int currNum in firstHashSet)
            {
                if (secondHashSet.Contains(currNum))
                {
                    nums.Add(currNum);
                }
            }

            Console.WriteLine(string.Join(' ',nums));
        }

        private static HashSet<int> Filset(HashSet<int> set, int length)
        {
            for (int i = 0; i < length; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }

            return set;
        }
    }
    
}
