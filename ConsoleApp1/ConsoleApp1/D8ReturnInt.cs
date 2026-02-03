using System;

namespace ConsoleApp1
{
    class D8ReturnInt
    {
        static void Main()
        {
            Console.Write("Masukan angka ke-1 : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Masukan angka ke-2 : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Masukan angka ke-3 : ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Masukan angka ke-4 : ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Masukan angka ke-5 : ");
            int e = int.Parse(Console.ReadLine());

            int[] numbers = { a, b, c, d, e };
            int total = HitungTotal(numbers);
            Console.WriteLine("Total: " + total);
        }

        static int HitungTotal(int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }
            
    }
}
