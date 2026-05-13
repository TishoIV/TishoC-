using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11._2
{
    class Shirokolistno : Durvo
    {
        private string formalista;
        private string vidploda;

        /*public Shirokolistno()
        {
        */
        public Shirokolistno(string imedarvo, string klimatichnaoblast, int nadmvisochinamax, int nadmvisochinamin, string formal, string vidplod)
            :base(imedarvo, klimatichnaoblast, nadmvisochinamax, nadmvisochinamin)
        {
            formalista = formal;
            vidploda = vidplod;

        }
        /*public void InputShirokolistno()
        {
            Input();
            Console.WriteLine("Въведете форма на листа: ");
            formalista = Console.ReadLine();
            Console.WriteLine("Въведете вид плод: ");
            vidploda = Console.ReadLine();
        }*/
        public void InfoShirokolistno()
        {
            InfoDarvo();
            Console.WriteLine($"Форма на листа: {formalista}");
            Console.WriteLine($"Вид плод: {vidploda}");
            Console.WriteLine();
        }
    }
}
