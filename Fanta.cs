using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDrink
{
    class Fanta : Softdrink
    {
        protected double procentsplodsok;

        public Fanta(double cena, double procentz, double procentpl, string mqstO) : base(cena, procentz, mqstO)
        {
            procentsplodsok = procentpl;


        }
        public void PrintFanta()
        { 
            Console.WriteLine("Въведи съдържание процент плодов сок");
            procentsplodsok = double.Parse(Console.ReadLine());
            
        }
        public void PrintFantaInfo()
        {
            Console.WriteLine("Информация за Фанта:");
            Console.WriteLine($"Процент плодов сок: {procentsplodsok} %");
        }

    }
}
