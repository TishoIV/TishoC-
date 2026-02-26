using System;

namespace Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Числа между 1-100, които се делят на 7: ");
            for (int i = 1; i<=91 ; i++)
            {
                if (i % 7 == 0)
                {

                }
                int res = i / 7;
                Console.WriteLine(res);
            }

        }
    }
}
