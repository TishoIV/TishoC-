
using System;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Прав ред: ");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + "");
            }
            Console.WriteLine("Обратен ред: ");
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i+ "");

            }
        }
    }
}
