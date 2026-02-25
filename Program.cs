//Програма коята пресмята  средния разход на автомобил за изминати 100 км. Обема на резорвоар за гориво и модела на автомобил се въвежда от потребитяла
//След пресмятането на разхода да се изведе следното съобщение: "Вашият среден разход е 100 км е 10 л/км, все пак е АУДИ"
using System;

namespace SredenRazhodAvt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете марката на автомобила: ");
            string model = Console.ReadLine();

            Console.Write("Въведете изразходваното гориво в литри за 100 км: ");
            double litri = double.Parse(Console.ReadLine());

            int km = 100;

            double sredenRazhod = (litri / km) * 100;

            Console.WriteLine($"Вашият среден разход за 100 км е {sredenRazhod:F2} л/100км, все пак е {model}");
        }
    }
}