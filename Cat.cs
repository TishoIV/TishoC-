using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._2
{
    class Cat : Pet
    {
        public override string GetSound()
        {
            return "Мяуу";
        }
        public override void InfoOutput()
        {
            Console.WriteLine($"Котка-име: {ime}, Котка-възраст: {vuzrast}");
        }

    }
}
