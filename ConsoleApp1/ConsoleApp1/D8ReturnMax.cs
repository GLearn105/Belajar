using System;

namespace ConsoleApp1
{
    class D8ReturnMax
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
            int max = HitungMax(numbers);
            Console.WriteLine("Nilai terbesar: " + max);
        }

        static int HitungMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}