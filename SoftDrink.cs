using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDrink
{
    class Softdrink
    {
        protected double cena;
        protected double procentszahar;
        protected string mqsto;

        public Softdrink()
        {

        }
        public Softdrink(double cen, double procentz, string mqstO)
        {
            cena = cen;
            procentszahar = procentz;
            mqsto = mqstO;
        }


        public void PrintDrink()
        {
  
            Console.WriteLine("Въведи цена: ");
            cena = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведи процент захар: ");
            procentszahar = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведи място на производство: ");
            mqsto = Console.ReadLine();

        }
            public void PrintDrinkInfo()
            {
                Console.WriteLine($"Цена: {cena} евро.");
                Console.WriteLine($"Процент захар: {procentszahar} %");
                Console.WriteLine($"Място на производство: {mqsto}");
        }
    }
}
