using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDrink
{
    class CocaCola : Softdrink
    {
        protected double procentskofein;
        public CocaCola()
        {

        }
        public CocaCola(double cen, double procentz, string mqstO, double procentkofe) : base(cen, procentz, mqstO)
        {
            procentskofein = procentkofe;

        }

        public void PrintCocaCola()
        {
            
            Console.WriteLine("Въведи процент кофеин: ");
            procentskofein = double.Parse(Console.ReadLine());

        }
        public void PrintCocaColaInfo()
        {
            Console.WriteLine("Информация за Кока-Кола:");
            Console.WriteLine($"Процент кофеин: {procentskofein} %");



        }
    }
}
