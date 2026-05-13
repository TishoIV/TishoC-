using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11._2
{
    class Durvo
    {
        protected string imedarvo;
        protected string klimatichnaoblast;
        protected int nadmvisochinamax;
        protected int nadmvisochinamin;

        /*public Durvo()
        {


        }*/
        public Durvo(string ime, string klimatob, int visochinamax, int visochinamin)
        {
            imedarvo = ime;
            klimatichnaoblast = klimatob;
            nadmvisochinamax = visochinamax;
            nadmvisochinamin = visochinamin;
        }
        /*public void Input()
        {
            Console.WriteLine("Въведете име на дърво: ");
            imedarvo = Console.ReadLine();
            Console.WriteLine("Въведете климатична област: ");
            klimatichnaoblast = Console.ReadLine();
            Console.WriteLine("Въведете надморска височина макс: ");
            nadmvisochinamax = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете надморска височина мин: ");
            nadmvisochinamin = int.Parse(Console.ReadLine());
        }*/
        public void InfoDarvo()
        {
            Console.WriteLine($"Име: {imedarvo}");
            Console.WriteLine($"Климатична област: {klimatichnaoblast}");
            Console.WriteLine($"Надморска височина (макс): {nadmvisochinamax}");
            Console.WriteLine($"Надморска височина (мин): {nadmvisochinamin}");
        }
    }
}
