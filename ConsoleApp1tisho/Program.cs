using System;

namespace ConsoleApp1tisho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double s = Math.PI * Math.Pow(r,2);
            int s2 = a * b;
            int s3 = (a * h) / 2;
            int s4 = a * h;
            int s5 = (a + b) * 2 / h;



            Console.WriteLine($"Лицето на правоъгълник:{s2}");
            Console.WriteLine($"Лице на кръг:{s}");
            Console.WriteLine($"Лице на триъгълник:{s3}");
            Console.WriteLine($"Лице на успоредник:{s4}");
            Console.WriteLine($"Лице на трапец:{s5}");





        }
    }
}
