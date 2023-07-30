using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson10_Task1
{
    public class Car : Transport
    {
        public Car(string name, string wayToTravel) : base(name, wayToTravel)
        {
        }

        public new void Move()
        {
            Console.WriteLine($"The {Name} is {WayToTravel} on the higway!");
        }
    }
}
