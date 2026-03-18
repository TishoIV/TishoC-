//Да се напише статичен метод, приемащ  един аргумент извеждаю аргумента повдигнат на 2 степен

using System;
using System.Diagnostics;

namespace LokFunkc1
{
    internal class LokFunkc2
    {
        static void StepenNaVtora(int chislo)
        {
            int stepen2 = chislo * chislo;
            Console.WriteLine($"{chislo} íà âòîðà ñòåïåí å: {stepen2}");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Âúâåäåòå ÷èñëî:");
            int chislo = int.Parse(Console.ReadLine());
            StepenNaVtora(chislo);

            

        }
    }
}
