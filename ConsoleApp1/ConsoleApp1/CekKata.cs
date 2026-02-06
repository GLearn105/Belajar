using System;

namespace COnsoleApp1
{
    class CekKata
    {
        static void Main()
        {
            Console.Write("Masukkan sebuah kalimat: ");
            string Kalimat = Console.ReadLine();
            Console.Write("Masukkan kata: ");
            string Kata = Console.ReadLine();

            string hasil = CekKataDalamKalimat(Kalimat, Kata);
            Console.WriteLine(hasil);

            // if (string.IsNullOrWhiteSpace(Kalimat) || string.IsNullOrWhiteSpace(Kata))
            // {
            //     Console.WriteLine("Kalimat dan kata tidak boleh kosong.");
            // }
            // else if (Kalimat.Contains(Kata))
            // {
            //     Console.WriteLine("Kata ditemukan.");
            // }
            // else
            // {
            //     Console.WriteLine("Kata tidak ditemukan.");
            // }
        }

        static String CekKataDalamKalimat(string kalimat, string kata)
        {
            if (string.IsNullOrWhiteSpace(kalimat) || string.IsNullOrWhiteSpace(kata))
            {
                return "Kalimat dan kata tidak boleh kosong.";
            }
            else if (kalimat.Contains(kata))
            {
                return "Kata ditemukan.";
            }
            else
            {
                return "Kata tidak ditemukan.";
            }
        }
    }
}