using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11._2
{
    class Iglolistno : Durvo
    {
        private string formashisharka;
        private int broiiglichki;

        /*public Iglolistno() 
        { 

        }*/
        
        public Iglolistno(string imedarvo, string klimatichnaoblast, int nadmvisochinamax, int nadmvisochinamin, string forma, int broiigli) 
            : base(imedarvo, klimatichnaoblast, nadmvisochinamax, nadmvisochinamin)
        {
            formashisharka = forma;
            broiiglichki = broiigli;

        }
        /*public void InputIglolistno()
        {
            Input();
            Console.WriteLine("Въведете форма на шишарка: ");
            formashisharka = Console.ReadLine();
            Console.WriteLine("Въведете брой иглички: ");
            broiiglichki = int.Parse(Console.ReadLine());
        }*/
        public void InfoIglolistno()
        {
            InfoDarvo();
            Console.WriteLine($"Форма на шишарка: {formashisharka}");
            Console.WriteLine($"Брой иглички: {broiiglichki}");
            Console.WriteLine();
        }



    }
}
