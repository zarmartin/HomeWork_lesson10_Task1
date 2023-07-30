using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson10_Task1
{
    public class Transport
    {
        public string WayToTravel { get; set; }
        public string Name { get; set; }

        public Transport(string name, string wayToTravel)
        {
            Name = name;
            WayToTravel = wayToTravel;  
        }
        public void Move() 
        {
            Console.WriteLine($"{Name} {WayToTravel}!");
        }      
    }
}
