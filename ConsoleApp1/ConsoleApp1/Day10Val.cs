using System;
namespace ConsoleApp1
{
     class Day10Val
    {
        static void Main()
        {
            while(true)
            {
                try
                {
                    int angka = AmbilAngka("Masukan Sebuah Angka : ");
                    Console.WriteLine("Angka yang dimasukan adalah : " + angka);
                    break; // keluar dari loop jika input valid
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input Harus berupa angka.");
                }
            }
        }

        static int AmbilAngka(string pesan)
        {
            Console.Write(pesan);

            int angka = Convert.ToInt32(Console.ReadLine());
            return angka;
        }
    }
}