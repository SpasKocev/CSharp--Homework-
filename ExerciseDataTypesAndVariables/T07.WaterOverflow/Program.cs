using System;

namespace T07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capasity = 255;
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                int nQontiti = int.Parse(Console.ReadLine());
                if (sum+nQontiti>capasity)
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
                else
                {
                    sum += nQontiti;
                    Console.WriteLine(sum);
                }
            }
          // Console.WriteLine(sum);
        }
    }
}
