// Да се създаде приложение, което създава масив от 20 елемента от целочислен тип и да се инициализира всеки от елементите със стойност, равна на индекса на елемнта умножен по 5. Елементите на масива да се изведат на конзолата.

using System;

namespace ZadachiMasiv
{
    internal class MasivZadacha2
    {
        static void Main(string[] args)
        {
            int[] masiv;
            masiv = new int[20];
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = i * 5;
            }
            for(int i = 0; i < masiv.Length; i++)
            {
                Console.WriteLine(masiv[i]);
            }






        }
    }
}
