//Да се напише локална функция която, приема 1 параметър, цяло число и звежда низ дали числото е положително, отрицателно или нула.

using System;
using System.Diagnostics;

namespace LokFunkc1
{
    internal class LokFunkc2
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Въведете цяло число:");
            int chislo = int.Parse(Console.ReadLine());
            string resultat = CheckNumber(chislo);
            Console.WriteLine(resultat);
            string CheckNumber(int num)
            {
                if (num > 0)
                {
                    return "Числото е положително.";
                }
                else if (num < 0)
                {
                    return "Числото е отрицателно.";
                }
                else
                {
                    return "Числото е нула.";
                }
            }


        }
    }
}
