using System;

namespace ConsoleApp1{
    class D8Array
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

            for (int i = 0; i < 5; i++)
            {
                Console.Write(numbers[i]);
            }
        }
    }
}