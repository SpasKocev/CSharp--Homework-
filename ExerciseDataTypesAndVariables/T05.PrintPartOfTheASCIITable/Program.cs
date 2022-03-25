using System;

namespace T05.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLine = int.Parse(Console.ReadLine());
            int secondLine = int.Parse(Console.ReadLine());
            for (int i = firstLine; i <= secondLine; i++)
            {
                Console.Write((char)i + " ");
               
            }
        }
    }
}
