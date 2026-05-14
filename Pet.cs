using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._2
{
    class Pet
    {
        protected string ime;
        protected int vuzrast;

        public string Ime 
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }
        public int Vuzrast
        {
            get
            {
                return vuzrast;
            }
            set
            {
                vuzrast = value;
            }
        }


        public virtual string GetSound()
        {
            return "звук";
        }
        public virtual void InfoInput()
        {
            Console.WriteLine("Въведи име: ");
            ime = Console.ReadLine();
            Console.WriteLine("Въведи възраст: ");
            vuzrast = int.Parse(Console.ReadLine());
        }
        public virtual void InfoOutput()
        {
            Console.WriteLine($"{this.GetType().Name}Име: {ime}, Възраст: {vuzrast}");
        }
    }
}
