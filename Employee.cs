using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._3
{
    internal class Employee
    {
        protected string ime;
        protected string familia;
        protected string poziciq;
        protected string grad;

        public string Ime
        {

            get { return ime; }

            set { ime = value; }
        }
        public string Familia
        {
            get { return familia; }
            set { familia = value; }

        }
        public string Poziciq
        {
            get { return poziciq; }
            set { poziciq = value; }
        }
        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }
        public Employee()
        {

        }
        public Employee(string ime, string familia, string poziciq, string grad)
        {
            this.ime = ime;
            this.familia = familia;
            this.poziciq = poziciq;
            this.grad = grad;

        }

        public virtual void ValueInfoInput()
        {
            Console.WriteLine("Въведи име: ");
            ime = Console.ReadLine();
            Console.WriteLine("Въведи възраст: ");
            ime = Console.ReadLine();
            Console.WriteLine("Въведи позиция: ");
            ime = Console.ReadLine();
            Console.WriteLine("Въведи град: ");
            ime = Console.ReadLine();
        }
        public virtual void ValueInfoOutput()
        {
            Console.WriteLine($"{ime}, {}");
        }
        public virtual string InfoEmployee()
        {
            return "длъжност на служителя";
        }
    }
}
