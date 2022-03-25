using System;

namespace T02._Sum_Digits
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] charArr = input.ToCharArray();
            int sum = 0;
            for (int i = 0; i <charArr.Length; i++)
            {
                sum += int.Parse(charArr[i].ToString());
            }
           Console.WriteLine(sum);
        }
    }
}
