using System;
using System.Linq;

namespace ConsoleApp1
{
    class List
    {
        static void Main()
        {
            Console.Write("Masukan Angka Pertama: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Masukan Angka Kedua: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Masukan Angka Ketiga: ");
            int c = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            numbers.Add(a);
            numbers.Add(b);
            numbers.Add(c);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            // Console.WriteLine(numbers[0] + " " + numbers[1] + " " + numbers[2]);
            Console.WriteLine("Angka terbesar: " + numbers.Max());
        }
    }
}