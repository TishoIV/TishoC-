using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._3
{
    internal class Kmet : Employee
    {
        public Kmet(string ime, string familia, string poziciq, string grad) : base(ime, familia, poziciq, grad)
        {

        }
        public override void ValueInfo()
        {
            Console.WriteLine($"Въведи Кмет-име: {ime} ");
            Console.WriteLine($"Въведи Кмет-фамилия: {familia}  ");
            Console.WriteLine($"Въведи Кмет-позиция: {poziciq}  ");
            Console.WriteLine($"Въведи Кмет-град: {grad}  ");

        }
        public override string InfoEmployee()
        {
            return "Кмет";
        }
    }
}
