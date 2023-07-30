using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson10_Task1
{
    public class Human : Transport
    {
        private Human(string name, string wayToTravel) : base(name, wayToTravel)
        {
        }

        public new void Walk()
        {
            Console.WriteLine($"{Name} {WayToTravel}");
        }
    }
}
