using System;
using System.Collections.Generic;

namespace T04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            FillDictionery(numbers, line);
            PrintRezult(numbers);
        }

        private static void PrintRezult(Dictionary<int, int> numbers)
        {
            int num = 0;
            foreach (KeyValuePair<int,int>kvp in numbers)
            {
                if (kvp.Value%2==0)
                {
                    num = kvp.Key;
                }
            }

            Console.WriteLine(num);
        }

        private static Dictionary<int,int> FillDictionery(Dictionary<int, int> numbers,
            int line)
        {
            for (int i = 0; i < line; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currNum))
                {
                    numbers.Add(currNum,0);
                }

                numbers[currNum]++;
            }

            return numbers;
        }
    }
}
