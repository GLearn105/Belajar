using System;

namespace ConsoleApp1
{
    class D10Catch
    {
        static void Main()
        {
            try
            {
                Console.Write("Masukan Angka pertama : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Angka kedua : ");
                int b = Convert.ToInt32(Console.ReadLine());
                int hasil = a / b;
                Console.WriteLine("Hasil: " + hasil);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input tidak valid! Harus angka.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("tidak boleh membagi dengan nol.");
            }
            finally
            {
                Console.WriteLine("Terima kasih telah menggunakan program ini.");
            }
        }
    }
}