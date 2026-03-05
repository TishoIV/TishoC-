using System;

namespace ZadachiMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            double[] myArr = new double[size];
            for (int i = 0; i < size; i++)
            {
                myArr[i]= double.Parse(Console.ReadLine());


            }
        
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"myArr[{i}]= {myArr[i]}");
            }
            foreach (double item in myArr)
            {
                Console.WriteLine(item);

            }
        }
    }
}
