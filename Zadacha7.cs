//Приложенеи коете се намира сумата на  произволно въведени положителни числа от клавиатурата. Въвеждането на стойности 0 да прекрати по нататъшното въвеждане на числа.
using System;

namespace Zadachki
{
    internal class Zadacha7
    {
        static void Main(string[] args)
        {
            double sum = 0;
            while(true)
            {
                Console.WriteLine("Въведете положително число (0 за край): ");
                double number = double.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                else if (number < 0)
                {
                    Console.WriteLine("Моля, въведете положително число.");
                    continue;
                }
                sum += number;
            }
            Console.WriteLine($"Сумата на въведените положителни числа е: {sum}");

        }
    }
}
