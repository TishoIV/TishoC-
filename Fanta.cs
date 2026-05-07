using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    class Fanta : SoftDrink
    {
        protected double procentsplodsok;

        public Fanta(double procentsplodsok, string mqstoFanta, double fantazahar) : base()
        {
            this.procentsplodsok = procentsplodsok;
            mqsto = mqstoFanta;
            procentszahar = fantazahar;
            
        }
        public void InputF()
        {
            Console.WriteLine("Информация за Фанта: ");
            Console.WriteLine("Въведи съдържание процент плодов сок");
            procentsplodsok = double.Parse(Console.ReadLine());
        }
        public void OutputF()
        {
            Console.WriteLine($"Процента плодов сок е: {procentsplodsok}");
        }
    }
}
