using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Tyres { get; set; }

        public void Printdata()
        {
            Console.WriteLine("Vehicle name: " + Name);
            Console.WriteLine("Vehcile speed: " + Speed);
            Console.WriteLine("Which tyres: " + Tyres);
        }

        public void ToString()
        {
            Console.WriteLine(" -Vehicle name: " + Name + " -Vehicle speed: " + Speed + " -Which tyres: " + Tyres);
        }

    }
}
