using System;

namespace ConsoleApp1
{
    class D10Try
    {
        static void Main()
        {
            
            try
            {
                Console.Write("Masukan Angka : ");
                int angka = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input Valid");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input tidak valid! Harus angka.");
            }
            finally
            {
                Console.WriteLine("Terima kasih telah menggunakan program ini.");
            }
        }
    }
}