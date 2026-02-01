using System;

namespace ConsoleApp1
{
    class HitungPersegi
    {
        static void Main()
        {
            Console.Write(" Masukan Sisi Persegi: ");
            int sisi = Convert.ToInt32(Console.ReadLine());

            // int luaspersegi = sisi * sisi;
            // Console.WriteLine("Luas Persegi adalah: " + luaspersegi);
            int luas = HitungLuasPersegi(sisi);
            Console.WriteLine("Luas Persegi adalah: " + luas);
        }

        static int HitungLuasPersegi(int sisi)
        {
            return sisi * sisi;
        }
    }
}