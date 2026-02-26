//Приложение чрез което се определя дали три въведени страни на тригълник и ако е изпълнено условието, да се определи вида на триъгълника

using System;

namespace Zadachicikli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a+b>c  && a+c>b && b+c>a)
            {
                Console.WriteLine("Образува триъгълник");
            }
            else
            {
                Console.WriteLine("Не образува триъгълник");
            }
            if (a==b && b==c)
            {
                Console.WriteLine("Равностранен триъгълник");

            }
            if (a == b || b == c || a == c)
            {
                Console.WriteLine("Равнобедрен триъгълник");

            }
            else
            {
                Console.WriteLine("Разностранен триъгълник");
            }
            
        }
    }
}
