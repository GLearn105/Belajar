using System;

namespace ConsoleApp1
{
    class LoopAngka
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
              if (i % 2 == 0)
            {
                Console.WriteLine(i + " Genap");
            }
            else
            {
                Console.WriteLine(i + " Ganjil");
            }  
            }
            
        }

    }
}