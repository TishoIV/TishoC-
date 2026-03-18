//Да се напише статичен метод, който приема един елемент цяло число и звежда таблицата за умножение с това число.

using System;
using System.Diagnostics;

namespace Zadacha3
{
    internal class LokFunkc1
    {
        static void moqtMethod(int chislo)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{chislo} x {i} = {chislo * i}");
            }
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("Въведете число:");
            int chislo = int.Parse(Console.ReadLine());
            moqtMethod(chislo);

        }
    }
}
