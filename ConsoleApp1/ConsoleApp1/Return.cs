using  System;

namespace ConsoleApp1
{
    class Return
    {
        static void Main()
        {
            int hasil = kalikan(5, 6);
            Console.WriteLine( hasil);
        }

        static int kalikan(int a, int b)
        {
            return a * b;
        }
    }
}