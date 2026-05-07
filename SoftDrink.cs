using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    class SoftDrink
    {
        protected double cena;
        protected double procentszahar;
        protected string mqsto;

        public SoftDrink()
        {

        }
        public SoftDrink(double cenA, double procent, string mqstO)
        {
            cena = cenA;
            procentszahar = procent;
            mqsto = mqstO;
        }
        

        public void Input()
        {
            Console.WriteLine("Информация за напитка: ");
            Console.WriteLine("Въведи цена: ");
            cena = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведи процент захар: ");
            procentszahar = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведи място на производство: ");
            mqsto = Console.ReadLine();

        }
        public void Output()
        {
            Console.WriteLine($"Цената е: {cena},  Захарта е: {procentszahar},  Мястото на производство е: {mqsto} ");
        }
    }
}
