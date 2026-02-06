using System;

namespace ConsoleApp1
{
    class ValidasiNama
    {
        static void Main()
        {
            Console.Write("Masukkan nama Anda: ");
            string NAMA = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(NAMA))
            {
                Console.WriteLine("Nama tidak boleh kosong.");
            }
            else if (NAMA.Trim().Length < 3)
            {
                Console.WriteLine("Nama Terlalu Pendek.");
            }
            else
            {
                Console.WriteLine($"Halo, {NAMA}!");
            }
        }
    }
}