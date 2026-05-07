using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    class CocaCola : SoftDrink
    {
        protected double procentskofein;
        public CocaCola()
        {

        }
        public CocaCola(double procentskofein, string mqstoCola, int Colazahar) : base()
        {
            this.procentskofein = procentskofein;
            mqsto = mqstoCola;
            procentszahar = Colazahar;
        }
        
        public void InputC()
        {
            Console.WriteLine("Информация за кока кола: ");
            Console.WriteLine("Въведи процент кофеин: ");
            procentskofein = double.Parse(Console.ReadLine());
        }

        public void OutputC()
        {
            Console.WriteLine($"Процента кофеин е: {procentskofein}");
        }

    }
}
