using System;

namespace ConsoleApp1
{
    class ReturnBool
    {
        static void Main()
        {
            Console.Write("Masukan Angka Pertama: ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Angka Kedua: ");
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            
            
            bool hasil = LebihBesar(a, b);
            // 5Console.WriteLine(hasil ? a + " lebih besar dari " + b : a + " tidak lebih besar dari " + b);

            // if (hasil)
            // {
            //     Console.WriteLine(a +" Lebih besar");
            // }
            // else
            // {
            //     Console.WriteLine(b +" Lebih besar atau sama");
            // }
        }

        static bool LebihBesar(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a + " Lebih besar");
                return true;
            }
            else
            {
                Console.WriteLine(b +" Lebih besar atau sama");
                return false;
            }
        }
    }
}