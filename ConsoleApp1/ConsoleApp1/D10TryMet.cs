using System;

namespace ConsoleApp1
{
    class D10TryMet
    {
        static void Main()
        {
            try
            {
                Console.Write("Masukan Angka pertama : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Angka kedua : ");
                int b = Convert.ToInt32(Console.ReadLine());
                int hasil = bagi(a, b);
                Console.WriteLine("Hasil: " + hasil);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input tidak valid! Harus angka.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int bagi(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("tidak boleh membagi dengan nol.");
            }
            
            return a / b;
        }
    }
}