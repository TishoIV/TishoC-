//Приложение с което се дефинира едномерен масив от n брой дробно-десетични елемента.
using System;

namespace ZadachaMasiv3
{
    internal class Zadacha3Masivt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете n: ");
           int n = int.Parse(Console.ReadLine());
           double[] masiv = new double [n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Елемент[{i}]");
                masiv[i] = int.Parse(Console.ReadLine());
            }
            double min = masiv[0];
            double max = masiv[0];
            int pozmin = 0;
            int pozmax = 0;
            double sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (masiv[i] < min) // Намиране на най-малка стойност
                {
                   min = masiv[i];
                   pozmin = i;
                }
                if (masiv[i] > max) //Намиране най-голяма стойност
                {
                    max = masiv[i];
                    pozmax = i;
                }
                sum += masiv[i];

            }

            Console.WriteLine($"Стойноста е: {min} на позиция {pozmin}");
            Console.WriteLine($"Стойноста е: {max} на позиция {pozmax}");
            Console.WriteLine($"Сумата е: {sum}");  




        }
    }
}
