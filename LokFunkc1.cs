//Да се запише локална функция, която приема едномерен масив и извърша действието на елементите на масива(принтира).

using System;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = { 4,5,6,7,8,9 };
            void Printmasiv(int[] masiv2)
            {
                foreach (int element in masiv2)
                {
                    Console.WriteLine(element);
                }
            }
            Printmasiv(masiv);
        
          





        }
    }
}