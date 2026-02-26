using System;

namespace Zadacha5
{
    internal class Zadacha5
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи число: ");
            int n = int.Parse(Console.ReadLine());
            int faktoriel = 1;
            for(int i = 1; i<=n; i++)
            {
                faktoriel *= i;
            }
            Console.WriteLine("");

        }
    }
}
