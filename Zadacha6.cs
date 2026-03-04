//Приложение на C#, с което се намира квадратно уравнение от вида ax^2 + bx + c = 0. Проверка за дали уравнението е квадратно т.е а различно от 0.

using System;

namespace Zadachki
{
    internal class Zadacha6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a= ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            double c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Уравнението не е квадратно");
            }
            else
            {
                Console.WriteLine("Уравнението е квадратно");




            }
            double discriminanta = b * b - 4 * a * c;
            Console.WriteLine($"Дискриминанта (D) = {discriminanta}");
            if (discriminanta > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminanta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminanta)) / (2 * a);
                Console.WriteLine($"x1={x1}");
                Console.WriteLine($"x1={x2}");
            }
            else if (discriminanta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Уравнението има един корен: x = {x}");
            }
            else
            {
                Console.WriteLine("Уравнението няма реални корени");
            }
        }
    }
}
   