using System;

namespace ConsoleApp1
{
    class CekGage
    {
        static void Main()
        {
            Console.Write("Masukan Angka: ");
            int angka = Convert.ToInt32(Console.ReadLine());
            bool cek = gage(angka);
            Console.WriteLine(angka + " adalah " + (cek ? "Genap" : "Ganjil"));
        }

        static bool gage(int angka)
        {
            if (angka % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}