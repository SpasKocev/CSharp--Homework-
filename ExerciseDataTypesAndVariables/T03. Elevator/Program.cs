using System;

namespace T03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int elevatePersons = int.Parse(Console.ReadLine());
            int capacityPersons = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)elevatePersons / capacityPersons);
            Console.WriteLine(courses);
        }
    }
}
