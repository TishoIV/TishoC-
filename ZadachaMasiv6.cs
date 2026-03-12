using System;

namespace ZadachaMasiv6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] stanciq = new string[9,1]
            {
                {"Ново село"},
                {"Видин" },
                {"Лом" },
                {"Оряхово" },
                {"Монтана" },
                {"Враца" },
                {"Кнежа" },
                {"Ловеч" },
                {"Плевен" },


            };
            string[,] temp = new string[9, 1]
            {
                {"8 " },
                {"8 " },
                {"8 " },
                {"8 " },
                {"15 " },
                {"14 " },
                {"8 " },
                {"10 " },
                {"13 " },
            };
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"{stanciq[i, 0]} с температура {temp[i, 0]} градуса");
            }


        }
    }
}

