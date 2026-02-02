using System;

namespace ConsoleApp1
{
    class SwitchCase
    {
        static void Main()
        {
            Console.Write("Masukan Angka (1-7): ");
            int angka = int.Parse(Console.ReadLine());
            string hari = HitungHari(angka);
            Console.WriteLine(hari);
        }

        static string HitungHari(int angka)
        {
            switch (angka)
            {
                case 1:
                    return " Hari Senin";
                    break;
                case 2:
                    return " Hari Selasa";
                    break;
                case 3:
                    return " Hari Rabu";
                    break;
                case 4:
                    return " Hari Kamis";
                    break;
                case 5:
                    return " Hari Jumat";
                    break;
                case 6:
                    return " Hari Sabtu";
                    break;
                case 7:
                    return " Hari Minggu";
                    break;
                default:
                    return "hari tidak valid";
                    break;
            }
        }
    }
}