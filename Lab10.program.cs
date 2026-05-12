using SoftDrink;
using System;
internal class Program
{
   static void Main(string[] args)
    {
        CocaCola cocaCola = new CocaCola();
        Console.WriteLine("/Кока-Кола/");
        cocaCola.PrintDrink();
        cocaCola.PrintCocaCola();
        Console.WriteLine("\n");
        cocaCola.PrintCocaColaInfo();
        cocaCola.PrintDrinkInfo();
        Console.WriteLine("\n");

        CocaColaZero cocaColaZero = new CocaColaZero(0, 0, "GABROVO", 0);
        Console.WriteLine("/Кока-Кола Зеро/");
        cocaColaZero.PrintDrink();
        cocaColaZero.PrintCocaColaInfo();
        cocaColaZero.PrintDrinkInfo();
        Console.WriteLine("\n");


        Fanta fanta = new Fanta(0, 0, 0, "");
        Console.WriteLine("/Фанта Портокал/");
        fanta.PrintDrink();
        fanta.PrintFanta();
        Console.WriteLine("\n");
        fanta.PrintFantaInfo();
        cocaCola.PrintDrinkInfo();
        Console.WriteLine("\n");

        
        FantaLemon fantaLemon = new FantaLemon(0, 0, 0, "");
        Console.WriteLine("/Фанта Лимон/");
        fantaLemon.PrintDrink();
        fantaLemon.PrintFanta();
        Console.WriteLine("\n");
        cocaCola.PrintDrinkInfo();
        fantaLemon.PrintFantaInfo();
    }
}
