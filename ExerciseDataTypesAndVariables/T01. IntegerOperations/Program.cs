using System;

namespace T01._IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
           // •Add first to the second.
          //•Divide(integer) the result of the first operation by the third number.
         //Multiply the result of the second operation by the fourth number.

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            int result = (firstNumber + secondNumber) / thirdNumber * fourthNumber;
            Console.WriteLine(result);
        }
    }
}
