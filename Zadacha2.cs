using System;

namespace ZadachiMasiv2
{
    internal class Zadacha2
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            double[] myArr = new double[size];
            for (int i = 0; i < size; i++)
            {
                myArr[i] = double.Parse(Console.ReadLine());


            }

            for (int i = 0; i < size; i++)
            {
                if(myArr[i]%2 == 0)
                {
                    Console.WriteLine($"myArr Chetni[{i+1}]= {myArr[i]}");
                }
                else
                {
                    Console.WriteLine($"myArr NeChetni[{i + 1}]= {myArr[i]}"); 
                }
               
            }
    
                /*foreach (double item in myArr)
                {
                    Console.WriteLine(item);

                }*/
        }
    }
}
