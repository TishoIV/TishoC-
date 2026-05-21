using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Rectangle : Figure
    {
        private double height;
        private double width;

        public Rectangle()
        {

        }
        public Rectangle(double h, double w)
        {
            height = h;
            width = w;
        }
        public override void Input()
        {
            Console.WriteLine("Въведи стойност за височина: ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведи стойност за широчина: ");
            width = double.Parse(Console.ReadLine());
        }

        public override void Ouput()
        {
            Console.WriteLine($"Височина е: {height} ");
            Console.WriteLine($"Широчина е: {width} ");

        }
        public override double Area()
        {
            return height * width;
        }

    }
}
