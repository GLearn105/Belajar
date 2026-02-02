using System;

namespace ConsoleApp1
{
    class Validasi
    {
        static void Main()
        {
            Console.Write("Masukan Nilai (0-100): ");
            int nilai = int.Parse(Console.ReadLine());
            string hasil = Hitung(nilai);
            Console.WriteLine(hasil);
        }
        static string Hitung(int nilai)
        {
            if (nilai >= 85)
            {
                return "A";
            }
            else if (nilai >= 70)
            {
                return " B";
            }
            else
            {
                return "C";
            }
        }
    }
}