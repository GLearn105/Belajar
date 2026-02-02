using System;

namespace ConsoleApp1
{
    class Array
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            // Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]} {numbers[3]} {numbers[4]}");
            // Console.WriteLine(numbers.Count());
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