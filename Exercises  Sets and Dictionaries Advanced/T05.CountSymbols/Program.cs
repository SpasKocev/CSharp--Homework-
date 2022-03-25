using System;
using System.Collections.Generic;

namespace T05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> sumbols = new SortedDictionary<char, int>();
            FillDictionary(sumbols, input);
            PrintResult(sumbols);
        }

        private static void PrintResult(SortedDictionary<char, int> sumbols)
        {
            foreach (var kvp in sumbols)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }

        private static SortedDictionary<char, int> FillDictionary(SortedDictionary<char, int> sumbols, string input)
        {
            foreach (char sumbol in input)
            {
                if (!sumbols.ContainsKey(sumbol))
                {
                    sumbols.Add(sumbol, 0);
                }

                sumbols[sumbol]++;
            }

            return sumbols;
        }
    }
}
