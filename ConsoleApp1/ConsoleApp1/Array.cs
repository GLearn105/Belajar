using System;

namespace ConsoleApp1
{
    class Array
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                total += numbers[i];
            }
            Console.WriteLine("Total: " + total);
        }
    }
}