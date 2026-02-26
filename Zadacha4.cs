using System;

namespace Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Числа между 1-100, които се делят на 7: ");
            for (int i = 1; i<100 ; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
               
            }

        }
    }
}
