using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._2
{
    class Dog : Pet
    {
        public override string GetSound()
        {
            return "Бау-бау";
        }
        public override void InfoOutput()
        {
            Console.WriteLine($"Куче-име: {ime}, Куче-възраст: {vuzrast}");
        }
    }
}
