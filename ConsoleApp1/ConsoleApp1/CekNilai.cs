using System;

namespace ConsoleApp1
{
    class CekNilai
    {
        static void Main()
        {
            Console.Write("Masukan Nilai Anda: ");
            int nilai = Convert.ToInt32(Console.ReadLine());
            if (nilai >= 80)
            {
                Console.WriteLine("A");
            }
            else if (nilai >= 70)
            {
                Console.WriteLine("B");
            }
            else if (nilai >= 60)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("D");
            }
            
        }

    }
}