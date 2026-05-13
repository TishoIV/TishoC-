using lab11._2;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //Въвеждане от потребителя на данни

        //Shirokolistno shirokolistno = new Shirokolistno();
        //shirokolistno.InputShirokolistno();
        //shirokolistno.InfoShirokolistno();


        //Iglolistno iglolistno = new Iglolistno();
        // iglolistno.InputIglolistno();
        //iglolistno.InfoIglolistno();



        // Широколистни дървета
        Console.WriteLine("Широколистни дървета:");
        Shirokolistno buk = new Shirokolistno("Бук", "Умерен климат", 1500, 0, "Овална", "Ореховиден плод");
        buk.InfoShirokolistno();
        Shirokolistno gabur = new Shirokolistno("Габър", "Умерен климат", 1200, 0, "Овална", "Ореховиден плод");
        gabur.InfoShirokolistno();
        Shirokolistno dub = new Shirokolistno("Дъб", "Умерен климат", 2000, 0, "Овална", "Ореховиден плод");
        dub.InfoShirokolistno();
        Console.WriteLine("\n");

        //Иглолистни дървета
        Console.WriteLine("Иглолистни дървета:");
        Iglolistno bqlbor = new Iglolistno("Бял бор", "Умерен климат", 2500, 0, "Конусовидна", 100);
        bqlbor.InfoIglolistno();
        Iglolistno cherenbor = new Iglolistno("Черeн бор", "Умерен климат", 2200, 0, "Конусовидна", 80);
        cherenbor.InfoIglolistno();
        Iglolistno smurch = new Iglolistno("Смърч", "Умерен климат", 3000, 0, "Конусовидна", 120);
        smurch.InfoIglolistno();
        Iglolistno ela = new Iglolistno("Ела", "Умерен климат", 2800, 0, "Конусовидна", 90);
        ela.InfoIglolistno();
        Iglolistno bqlamura = new Iglolistno("Бяла мура", "Умерен климат", 3500, 0, "Конусовидна", 150);
        bqlamura.InfoIglolistno();

    }
}