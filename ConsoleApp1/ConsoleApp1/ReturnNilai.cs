using System;

namespace ConsoleApp1
{
    class ReturnNilai
    {
        static void Main()
        {
            Console.Write("Masukan Nilai: ");
            int nilai = Convert.ToInt32(Console.ReadLine());
            string hasil = Hitunghasil(nilai);
            Console.WriteLine(hasil);
        }

        static string Hitunghasil(int nilai)
        {
            if (nilai >= 80)
            {
                return "Lulus Dengan Baik";
            }
            else if (nilai >= 60)
            {
                return "Lulus";
            }
            else 
            {
                return "Tidak Lulus";
           
            }
        }
    }
}