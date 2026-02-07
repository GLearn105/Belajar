using System;

namespace ConsoleApp1
{
    class D10TryLoop
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Masukan Angka : ");
                    int angka = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Angka Valid " + angka);
                    break; // Keluar dari loop jika input valid
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input tidak valid! Harus angka.");
                }
            }
        }
    }
}